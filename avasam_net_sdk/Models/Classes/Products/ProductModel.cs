using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    /// <summary>
    /// This class used for product details model
    /// </summary>
    public class ProductModel : BaseRequest
    {
        /// <summary>
        /// using for unique id
        /// </summary>
        public string _id { get; set; }
        /// <summary>
        /// using for product sku 
        /// </summary>
        [Required(ErrorMessage = "SKU is required.")]
        public string SKU { get; set; }
        /// <summary>
        /// using for product title
        /// </summary>
        [Required(ErrorMessage = "ProductTitle is required.")]
        public string Title { get; set; }
        /// <summary>
        /// using for product barcode
        /// </summary>
        [Required(ErrorMessage = "ProductBarCode is required.")]
        public string BarCode { get; set; }
        /// <summary>
        /// using for product category name
        /// </summary>
        [Required(ErrorMessage = "ProductCategory is required.")]
        public string Category { get; set; }
        /// <summary>
        /// using for product description
        /// </summary>
        [Required(ErrorMessage = "ProductDescription is required.")]
        public string Description { get; set; }
        /// <summary>
        /// using for product pack quantity
        /// </summary>
        //[Required(ErrorMessage = "ProductQuantity is required.")]
        public string PackQty { get; set; }
        /// <summary>
        /// using for item minimum level
        /// </summary>
        [Required(ErrorMessage = "ProductMinimumLevel is required.")]
        public string MinimumLevel { get; set; }
        /// <summary>
        /// using for product price
        /// </summary>
        [Required(ErrorMessage = "ProductPrice is required.")]
        public string Price { get; set; }
        /// <summary>
        /// using for product cost price
        /// </summary>
        [Required(ErrorMessage = "ProductRetailPrice is required.")]
        public string costprice { get; set; }
        /// <summary>
        /// using for product vat
        /// </summary>
        [Required(ErrorMessage = "ProductTaxRate is required.")]
        public string Vat { get; set; }
        /// <summary>
        /// using for product depth
        /// </summary>
        [Required(ErrorMessage = "ProductDepth is required.")]
        public string ProductDepth { get; set; }
        /// <summary>
        /// using for product weight
        /// </summary>
        [Required(ErrorMessage = "ProductWeight is required.")]
        public string ProductWeight { get; set; }
        /// <summary>
        /// using for product width
        /// </summary>
        [Required(ErrorMessage = "ProductWidth is required.")]
        public string ProductWidth { get; set; }
        /// <summary>
        /// using for product height
        /// </summary>
        [Required(ErrorMessage = "ProductHeight is required.")]
        public string Height { get; set; }
        /// <summary>
        /// using for product image
        /// </summary>
        public List<string> ProductImage { get; set; }
        /// <summary>
        /// using for extended property class
        /// </summary>
        public List<ExtendedProperties> ExtendedProperties { get; set; }
        /// <summary>
        /// using for create on datetime
        /// </summary>
        public DateTime CreateOn { get; set; }
        /// <summary>
        /// using for update item update datetime
        /// </summary>
        public DateTime UpdateOn { get; set; }
        /// <summary>
        /// using for isvariation true or false
        /// </summary>
        public bool IsVariation { get; set; }
        /// <summary>
        /// using for variation class
        /// </summary>
        public List<variatonlist> Variations { get; set; }
        /// <summary>
        /// using for product isactive true or false
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// using for product selected categoryid
        /// </summary>
        public string CategoryId { get; set; }
    }

    /// <summary>
    /// This class used for product update details
    /// </summary>
    public class ProductUpdateModel
    {
        /// <summary>
        /// using for product model class
        /// </summary>
        public List<ProductModel> UpdateProductModel { get; set; }
        /// <summary>
        /// using for list of product delete list
        /// </summary>
        public List<string> DeleteProductList { get; set; }
    }

    /// <summary>
    /// This class used for product module filter details
    /// </summary>
    public class ProductModuleFilterModel
    {
        /// <summary>
        /// using for product from datetime
        /// </summary>
        public DateTime FromDate { get; set; }
        /// <summary>
        /// using for to datetime 
        /// </summary>
        public DateTime ToDate { get; set; }
        /// <summary>
        /// using for lfrom date time
        /// </summary>
        public long lFromDate { get; set; }
        /// <summary>
        /// using for lto datetime
        /// </summary>
        public long lToDate { get; set; }
        /// <summary>
        /// using for is null category data true or false
        /// </summary>
        public bool IsNullCategoryData { get; set; }
        /// <summary>
        /// using for product sku
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// using for showdeleted data true or false
        /// </summary>
        public bool showdeleted { get; set; }
        /// <summary>
        /// using for page limit display
        /// </summary>
        public int limit { get; set; }
        /// <summary>
        /// using for page number display
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// using for sort by display
        /// </summary>
        public string sortby { get; set; }
        /// <summary>
        /// using for sort status name
        /// </summary>
        public string SortStatus { get; set; }
        /// <summary>
        /// using for price delimeter
        /// </summary>
        public string PriceDelimeter { get; set; }
        /// <summary>
        /// using for price value
        /// </summary>
        public Double PriceValue { get; set; }
        /// <summary>
        /// using for selected category list
        /// </summary>
        public List<string> SelectedCategoryList { get; set; }
        /// <summary>
        /// using for supplier name
        /// </summary>
        public string Supplier { get; set; }

    }

    /// <summary>
    /// This class used for file info details
    /// </summary>
    public class FileInfos
    {
        /// <summary>
        /// using for file path
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// using for file type
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// using for file image name
        /// </summary>
        public string imagename { get; set; }
    }

    /// <summary>
    /// This class used for image data to pass details
    /// </summary>
    public class ImagedataToPass
    {
        /// <summary>
        /// using for item sku
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// using for product image
        /// </summary>
        public string ProductImage { get; set; }
    }

    /// <summary>
    /// This class used for extended properties details
    /// </summary>
    public class ExtendedProperties
    {
        /// <summary>
        /// using for extended property name
        /// </summary>
        [Required(ErrorMessage = "Extended properties name is required.")]
        public string Name { get; set; }
        /// <summary>
        /// using for extended property value
        /// </summary>
        [Required(ErrorMessage = "Extended properties value is required.")]
        public string Value { get; set; }
    }

    /// <summary>
    /// This class used for properties data to pass details
    /// </summary>
    public class PropertiesdataToPass
    {
        /// <summary>
        /// using for product sku
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// using for extended property name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// using for extended property value
        /// </summary>
        public string Value { get; set; }
    }

    /// <summary>
    /// This class used for variation list details 
    /// </summary>
    public class variatonlistmodel
    {
        /// <summary>
        /// using for product sku
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// using for product title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// using for parent product sku
        /// </summary>
        public string ParentSKU { get; set; }
    }
}
