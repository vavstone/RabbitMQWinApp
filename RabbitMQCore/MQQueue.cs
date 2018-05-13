using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQCore
{
    [DataContract]
    public class MQQueue
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "vhost")]
        public string Vhost { get; set; }
        [DataMember(Name = "state")]
        public string State { get; set; }
        [DataMember(Name = "exclusive")]
        public string Exclusive { get; set; }
        [DataMember(Name = "durable")]
        public bool Durable { get; set; }
        [DataMember(Name = "auto_delete")]
        public bool AutoDelete { get; set; }
        [DataMember(Name = "messages")]
        public int Messages { get; set; }
    }
}
