using System;
using System.Collections.Generic;
using System.Text;

namespace avasam_net_sdk.Models.Classes
{
    public class GetOrdersRequest
    {
        public string OrderNumber { get; set; }
        public string supplier { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
    }
}
