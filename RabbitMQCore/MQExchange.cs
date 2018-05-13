using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQCore
{
    [DataContract]
    public class MQExchange
    {
        [DataMember(Name ="name")]
        public string Name { get; set; }
        [DataMember(Name = "vhost")]
        public string Vhost { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "durable")]
        public bool Durable { get; set; }
        [DataMember(Name = "auto_delete")]
        public bool AutoDelete { get; set; }
        [DataMember(Name = "internal")]
        public bool Internal { get; set; }
    }
}
