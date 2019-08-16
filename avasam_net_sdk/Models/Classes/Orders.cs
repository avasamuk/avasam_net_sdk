using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    public class Orders : BaseContext
    {

        public Orders(LoginResponse apiContext) : base(apiContext)
        {
        }

        // Search Order By Order Id
        public async Task<List<DropShipperOrders>> GetOrders(GetOrdersRequest value)
        {
            return await Post<List<DropShipperOrders>>("api/SellerOrdersView/SellerGetOrdersListWithFilter", (new SellerGetOrdersListWithFilterRequest()
            {
                Customer = string.IsNullOrWhiteSpace(value.OrderNumber) ? "All" : value.OrderNumber,
                CustomerId = string.IsNullOrWhiteSpace(value.OrderNumber) ? "All" : value.OrderNumber,
                Date = null,
                DateDispaly = "Last 7 days",
                FromDate = DateTime.UtcNow.AddDays(-3).ToString("yyyy-MM-ddTHH:mm:ss"),
                IsToday = "false",
                OrderStatus = "All",
                PaymentStatus = "All",
                SortStatus = "down",
                Sortby = "CustomerName",
                ToDate = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss"),
                customerId = "All",
                limit = value.limit.ToString(),
                page = value.page
            }).ToJson());
        }

        /// <summary>
        /// Get Products for Order Creation
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <param name="Supplier"></param>
        /// <param name="SKU"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public async Task<ProductFeed> GetOrderProducts(string CustomerId, string Supplier, string SKU, string page, string limit)
        {
            return await Post<ProductFeed>("api/ProductCatalog/NewGetCustProductListWithSupplierCode/" + CustomerId + "/" + Supplier + "/" + SKU + "/" + page + "/" + limit, null);
        }

        /// <summary>
        /// Create Order
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<UpdateResp> CreateOrders(OrderViewModel value)
        {
            return await Post<UpdateResp>("api/OrdersCreation/CreateNewOrder", (new OrderViewModel()
            {
                BillingAddress = value.BillingAddress,
                CustomerID = value.CustomerID,
                CustomerInfo = value.CustomerInfo,
                CustomerName = value.CustomerName,
                CustomerType = value.CustomerType,
                GeneralInfo = value.GeneralInfo,
                Items = value.Items,
                Notes = value.Notes,
                ShippingInfo = value.ShippingInfo,
                ShippingService = value.ShippingService
            }).ToJson());
        }

        /// <summary>
        /// Dispatch Order
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<UpdateResp> OrderDispatchProcess(DispatchProcess value)
        {
            return await Post<UpdateResp>("api/OrderDispatch/OrderDispatchProcess", (new DispatchProcess()
            {
                _id = value._id,
                CustomerId = value.CustomerId,
                TrackingNumber = value.TrackingNumber,
                ShippingMethod = value.ShippingMethod,
                PostalServiceName = value.PostalServiceName,
                NumOrderId = value.NumOrderId,
                CustomerOrderId = value.CustomerOrderId,
                OrderId = value.OrderId,
            }).ToJson());
        }

        /// <summary>
        /// Find Supplier
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        public async Task<List<CustomerFind>> FindSupplier(string supplier)
        {
            return await Get<List<CustomerFind>>("api/CustomerView/FindSupplier/" + supplier, null);
        }
    }
}
