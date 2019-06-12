using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    /// OrdersCreationController.cs
    /// <summary>
    /// This class is used to display BillingAddressModel
    /// </summary>
    public class BillingAddressModel
    {
        /// <summary>
        /// used to display EmailAddress
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// used to display Address1
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// used to display businessName
        /// </summary>
        public string BusinessName { get; set; }
        /// <summary>
        /// used to display Telephone
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// used to display Country
        /// </summary>
        public string Country { get; set; }

    }
}
