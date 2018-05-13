using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RabbitMQCore
{
    public enum MQExchangeTypes
    {
        direct, fanout, topic, headers
    }

    public class MQReceivedEventArgs: EventArgs
    {
        public string Message { get; set; }
        public MQReceivedEventArgs(string message)
        {
            Message = message;
        }
    }

    public class MQWorker:IDisposable
    {
        public string HostName { get; set; }
        public string VirtualHost { get; set; }
        public int? Port { get; set; }
        public string UserName { get;set;}
        public string Password { get; set; }

        ConnectionFactory factory;
        IConnection connection;
        IModel channel;
        public event EventHandler<MQReceivedEventArgs> MessageReceivedEvent;
        string consumerTag = "";

        public MQWorker(string hostName, int? port = null, string virtualHost = null, string userName = null, string password = null)
        {
            HostName = hostName; Port = port; UserName = userName; Password = password; VirtualHost = virtualHost;
            SetFactory();
        }

        void SetFactory()
        {
            factory = new ConnectionFactory();
            factory.HostName = HostName;
            if (Port != null)
                factory.Port = Port.Value;
            if (!string.IsNullOrWhiteSpace(VirtualHost))
                factory.VirtualHost = VirtualHost;
            if (!string.IsNullOrWhiteSpace(UserName))
                factory.UserName = UserName;
            if (!string.IsNullOrWhiteSpace(Password))
                factory.Password = Password;
            connection = factory.CreateConnection();
            channel = connection.CreateModel();
        }

        public void CreateExchange(string exchange, MQExchangeTypes exchangeType, bool durable, bool autoDelete)
        {
            channel.ExchangeDeclare(exchange: exchange, type: exchangeType.ToString(), durable: durable, autoDelete: autoDelete);
        }

        public void CreateQueue(string queue, bool durable, bool exclusive, bool autoDelete)
        {
            channel.QueueDeclare(queue: queue, durable: durable, exclusive: exclusive, autoDelete: autoDelete);
        }

        public string CreateQueue(bool durable, bool exclusive, bool autoDelete)
        {
            return channel.QueueDeclare(durable: durable, exclusive: exclusive, autoDelete: autoDelete).QueueName;
        }

        public void BindQueue(string queue, string exchange, string routingKey)
        {
            channel.QueueBind(queue: queue, exchange: exchange, routingKey: routingKey);
        }

        public string SendMessage(string message, string exchange, string routingKey, bool persistent)
        {
            try
            {
                var prop = channel.CreateBasicProperties();
                if (persistent)
                    prop.Persistent = true;
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange, routingKey, prop, body);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void StartRecievingMessages(string queue, bool useTempQueue)
        {
            var qName = queue;
            if (useTempQueue)
                qName = CreateQueue(false, false, false);
            channel.BasicQos(0, 1, false);
            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);
                OnMessageReceived(message);
                channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            };
            consumerTag = channel.BasicConsume(queue: qName, autoAck: false, consumer: consumer);
        }

        public void StopReceivingMessages()
        {
            channel.BasicCancel(consumerTag);
        }

        void OnMessageReceived(string message)
        {
            MessageReceivedEvent?.Invoke(this, new MQReceivedEventArgs(message));
        }

        static HttpClient CreateHttpClient(string user, string password)
        {
            var authValue = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{user}:{password}")));
            return new HttpClient { DefaultRequestHeaders = { Authorization = authValue } };
        }
                       
        public static async Task<List<T>> GetMQObjectsListAsync<T>(string path, string admUser, string admPassword)
        {
            List<T> result = null;
            var url = HttpUtility.HtmlEncode(path);
            var client = CreateHttpClient(admUser, admPassword);
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var ser = new DataContractJsonSerializer(typeof(List<T>));
                var stream = await client.GetStreamAsync(url);
                result = ser.ReadObject(stream) as List<T>;
            }
            return result;
        }

        public static async Task<string> DeleteMQObject(string path, string admUser, string admPassword)
        {
            var client = CreateHttpClient(admUser, admPassword);
            var url = HttpUtility.HtmlEncode(path);
            HttpResponseMessage response = await client.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
                return "Объект удален";
            return response.StatusCode.ToString();
        }

        public void Dispose()
        {
            channel.Close();
            connection.Close();
            channel.Dispose();
            connection.Dispose();
        }
    }
}
