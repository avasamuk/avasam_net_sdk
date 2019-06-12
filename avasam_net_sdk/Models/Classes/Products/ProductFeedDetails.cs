using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    /// <summary>
    /// This class used for product feed detils 
    /// </summary>
    public class ProductFeedDetails : BaseRequest
    {
        /// <summary>
        /// unique id for ProductFeed collection
        /// </summary>
    
        public string _id { get; set; }
        /// <summary>
        /// display the sku of the product 
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// using for display the price 
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// using for cost price display
        /// </summary>
        public double costprice { get; set; }
        /// <summary>
        /// using for display the title of the product
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// using for display the barcode of the product
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// using for display the vat
        /// </summary>
        public double Vat { get; set; }
        /// <summary>
        /// using for display the quantity
        /// </summary>
        public int PackQty { get; set; }
        /// <summary>
        /// using for display the customer group name
        /// </summary>
        public string CustomerGroup { get; set; }
        /// <summary>
        /// using for display the image
        /// </summary>
        public string image { get; set; }
        /// <summary>
        /// using for category name
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// using for description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// using for minimum level stock
        /// </summary>
        public int MinimumLevel { get; set; }
        /// <summary>
        /// using for retail price
        /// </summary>
        public double RetailPrice { get; set; }
        /// <summary>
        /// using for product depth
        /// </summary>
        public double ProductDepth { get; set; }
        /// <summary>
        /// using for product weight
        /// </summary>
        public double ProductWeight { get; set; }
        /// <summary>
        /// using for product width
        /// </summary>
        public double ProductWidth { get; set; }
        /// <summary>
        /// using for product height
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// using for product image
        /// </summary>
        public List<string> ProductImage { get; set; }
        /// <summary>
        /// using for extended properties
        /// </summary>
        public List<ExtendedProperties> ExtendedProperties { get; set; }
        /// <summary>
        /// using for create datetime
        /// </summary>
        public DateTime CreateOn { get; set; }
        /// <summary>
        /// using for update datetime
        /// </summary>
        public DateTime UpdateOn { get; set; }
        /// <summary>
        /// using for isvariation true or false
        /// </summary>
        public bool IsVariation { get; set; }
        /// <summary>
        /// using for variation list class
        /// </summary>
        public List<variatonlist> Variations { get; set; }
        /// <summary>
        /// using for sku name
        /// </summary>
        public string SKUSmall { get; set; }
        /// <summary>
        /// using for isactive true or false
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// using for multiple language title
        /// </summary>
        public Dictionary<string, string> MultiTitle { get; set; }
        /// <summary>
        /// using for multiple description
        /// </summary>
        public Dictionary<string, string> MultiDescription { get; set; }
        /// <summary>
        /// using for category id
        /// </summary>
        public string CategoryId { get; set; }
    }

    /// <summary>
    /// This class used for variation details
    /// </summary>
    public class variatonlist
    {
        /// <summary>
        /// using for product sku name
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// using for product title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// using for isactive true or false
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// using for isselected true or false
        /// </summary>
        public bool IsSelected { get; set; }
        }
}
