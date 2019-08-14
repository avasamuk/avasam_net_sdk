using System;
using System.Collections.Generic;
using System.Text;

namespace avasam_net_sdk.Models.Classes
{
    /// <summary>
    /// Price update model used in product cotroller
    /// </summary> 
    public class PriceUpdate
    {
        /// <summary>
        /// Product SKU
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// Product Price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Product RRP ( recommended retail price )
        /// </summary>
        public double RRP { get; set; }
    }
}
