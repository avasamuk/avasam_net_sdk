using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    /// OrdersCreationController.cs
    /// <summary>
    /// This class is used to display OrderViewModel
    /// </summary>
    public class OrderViewModel
    {
        /// <summary>
        ///  used to display GeneralInfo
        /// </summary>
        public GeneralInfoModel GeneralInfo { get; set; }

        /// <summary>
        ///  used to display ShippingInfo
        /// </summary>
        public ShippingInfoModel ShippingInfo { get; set; }
        /// <summary>
        ///  used to display CustomerInfo
        /// </summary>
        public AddressModel CustomerInfo { get; set; }
        /// <summary>
        ///  used to display BillingAddress
        /// </summary>
        public BillingAddressModel BillingAddress { get; set; }
        /// <summary>
        ///  used to display list of Items
        /// </summary>
        public List<ItemModel> Items { get; set; }
        /// <summary>
        ///  used to display CustomerId
        /// </summary>
        [Required(ErrorMessage = "Please select customer name.")]
        public string CustomerID { get; set; }
        /// <summary>
        ///  used to display customername
        /// </summary>
        [Required(ErrorMessage = "Customer Name Required")]
        public string CustomerName { get; set; }
        /// <summary>
        ///  used to display notes
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        ///  used to display Customer Type
        /// </summary>
        public string CustomerType { get; set; }
        /// <summary>
        ///  used to display ShippingService
        /// </summary>
        public string ShippingService { get; set; }
    }
}
