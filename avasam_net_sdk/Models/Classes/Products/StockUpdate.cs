using System;
using System.Collections.Generic;
using System.Text;

namespace avasam_net_sdk.Models.Classes
{
    public class StockUpdate
    {
        /// <summary>
        /// Product SKU
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// Product Stock 
        /// </summary>
        public int Stock { get; set; }
    }
}
