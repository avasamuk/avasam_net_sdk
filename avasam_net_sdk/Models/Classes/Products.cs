using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
   public class Products : BaseContext
    {
        public Products(LoginResponse apiContext) : base(apiContext)
        {
        }

        public async Task<LoginResponse> Login(string Email, string Password)
        {
            return await Post<LoginResponse>("api/Signup/Login", (new LoginRequest()
            {
                Email = Email,
                Password = Password
            }).ToJson());
        }

        /// <summary>
        /// Get Products Full Details Search By Supplier & SKU
        /// </summary>
        /// <param name="supplier"></param>
        /// <param name="sku"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public async Task<ProductFeedDetails> GetProducts(string supplier,string sku,int page,int limit)
        {
            return await Post<ProductFeedDetails>("api/ProductSDK/GetShipperProductList", (new GetProductsRequest()
            {
                supplier = supplier,
                sku = sku,
                limit = limit,
                page = page
            }).ToJson());
        }


        /// <summary>
        /// Create Products
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<UpdateResp> CreateProducts(ProductModel value)
        {
            return await Post<UpdateResp>("api/ProductModule/SaveNewProduct", (new ProductModel()
            {
               authkey = value.authkey,
               BarCode = value.BarCode,
               Category = value.Category,
               CategoryId = value.CategoryId,
               costprice = value.costprice,
               CreateOn = DateTime.Now,
               Description = value.Description,
               ExtendedProperties = value.ExtendedProperties,
               Height = value.Height,
               IsActive = value.IsActive,
               IsVariation = value.IsVariation,
               MinimumLevel = value.MinimumLevel,
               PackQty = value.PackQty,
               Price = value.Price,
               ProductDepth = value.ProductDepth,
               ProductImage = value.ProductImage,
               ProductWeight = value.ProductWeight, 
               ProductWidth = value.ProductWidth, 
               seekerid =value.seekerid,
               shipperid =value.seekerid,
               SKU = value.SKU,
               Title = value.Title,
               UpdateOn = value.UpdateOn,
               Variations = value.Variations,
               Vat = value.Vat,
               _id = value._id
            }).ToJson());
        }

        /// <summary>
        /// Bulk Import Product (Maximum 100 items per request)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, string>> BulkProductImport(List<ProductModel> value)
        {
            return await Post<Dictionary<string, string>>("api/Products/BulkProductImport", (value).ToJson());
        }

        /// <summary>
        /// Bulk Price Update (Maximum 100 items per request)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, string>> PriceUpdate(List<PriceUpdate> value)
        {
            return await Post<Dictionary<string, string>>("api/Products/PriceUpdate", (value).ToJson());
        }

        /// <summary>
        /// Bulk stock Update (Maximum 100 items per request)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, string>> StockUpdate(List<StockUpdate> value)
        {
            return await Post<Dictionary<string, string>>("api/Products/StockUpdate", (value).ToJson());
        }
    }
}
