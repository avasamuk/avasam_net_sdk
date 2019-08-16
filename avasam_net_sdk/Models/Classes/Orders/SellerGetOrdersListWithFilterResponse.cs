using System;
using System.Collections.Generic;
using System.Text;

namespace avasam_net_sdk.Models.Classes
{
    public class SellerGetOrdersListWithFilterResponse
    {
        public int total { get; set; }
        public List<DropShipperOrders> data { get; set; }
    }
}
