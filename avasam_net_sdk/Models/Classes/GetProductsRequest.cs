using System;
using System.Collections.Generic;
using System.Text;

namespace avasam_net_sdk.Models.Classes
{
    public class GetProductsRequest
    {
        public string sku { get; set; }
        public string supplier { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
    }
}
