using System;
using System.Collections.Generic;
using System.Text;

namespace avasam_net_sdk.Models.Classes
{
    public class SellerGetOrdersListWithFilterRequest
    {
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string DateDispaly { get; set; }
        public string IsToday { get; set; }
        public object Date { get; set; }
        public string Customer { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public string Sortby { get; set; }
        public string SortStatus { get; set; }
        public string limit { get; set; }
        public string customerId { get; set; }
        public int page { get; set; }
        public string CustomerId { get; set; }
        public string lToDate { get; set; }
    }
}
