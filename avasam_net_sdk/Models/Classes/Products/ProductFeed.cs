
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    /// <summary>
    /// This class used for product details
    /// </summary>
    public class ProductFeed : BaseRequest
    {
        /// <summary>
        /// using for get updated price display 
        /// </summary>
        public object GetUpdatePrice;
        /// <summary>
        /// Using for unique id for ProductFeed collection
        /// </summary>

        public string _id { get; set; }
        /// <summary>
        /// display the sku of the product 
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// display the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Using for cost price display
        /// </summary>
        public double costprice { get; set; }
        /// <summary>
        /// display the title of the product 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// display the barcode of the product
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// display the vat
        /// </summary>
        public double Vat { get; set; }
        /// <summary>
        /// display the quantity
        /// </summary>
        public int PackQty { get; set; }
        /// <summary>
        /// Using for customer group name
        /// </summary>
        public string CustomerGroup { get; set; }
        /// <summary>
        /// Using for product image 
        /// </summary>
        public string image { get; set; }
        /// <summary>
        /// Using for product create on datetime
        /// </summary>
        public DateTime CreateOn { get; set; }
        /// <summary>
        /// Using for product update on datetime
        /// </summary>
        public DateTime UpdateOn { get; set; }
        /// <summary>
        /// Using for isactive product true or false
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Using for is variation true or false
        /// </summary>
        public bool IsVarP { get; set; }
        /// <summary>
        /// Using for variation option list
        /// </summary>
        public string[] VarationOp { get; set; }
        /// <summary>
        /// Using for multiple language title
        /// </summary>
        public Dictionary<string, string> MultiTitle { get; set; }
        /// <summary>
        /// Using for product sku
        /// </summary>
        public string SKUSmall { get; set; }
        /// <summary>
        /// Using for stock updated on datetime
        /// </summary>
        public DateTime StockUpdateOn { get; set; }
        /// <summary>
        /// Using for price updated on datetime
        /// </summary>
        public DateTime PriceUpdateOn { get; set; }
        //public object ProductFeed { get; set; }
    }
}
