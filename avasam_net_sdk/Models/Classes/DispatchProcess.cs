using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    public class DispatchProcess
    {
        public string _id { get; set; }
        public string OrderId { get; set; }
        public string NumOrderId { get; set; }
        public string CustomerOrderId { get; set; }
        public string CustomerId { get; set; }
        public string TrackingNumber { get; set; }
        public string PostalServiceName { get; set; }
        public string ShippingMethod { get; set; }
    }
}
