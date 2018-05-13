using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQCore
{
    [DataContract]
    public class MQBinding
    {
        [DataMember(Name = "source")]
        public string Source { get; set; }
        [DataMember(Name = "vhost")]
        public string Vhost { get; set; }
        [DataMember(Name = "destination")]
        public string Destination { get; set; }
        [DataMember(Name = "destination_type")]
        public string DestinationType { get; set; }
        [DataMember(Name = "routing_key")]
        public string RoutingKey { get; set; }
    }
}
