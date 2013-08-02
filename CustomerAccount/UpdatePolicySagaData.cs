using Model.Model;
using NServiceBus.Saga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAccountSystem
{
    public class UpdatePolicySagaData : IContainSagaData
    {
        // the following properties are mandatory
        public Guid Id { get; set; }
        public string Originator { get; set; }
        public string OriginalMessageId { get; set; }

        // all other properties you want persisted
        public Guid TrackingNumber { get; set; }

        // complex sample objects
        public Dictionary<string, List<string>> ProcessedEventIds { get; set; }
        public List<Customer> TestCustomerObject { get; set; }
    }
}
