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
    /// This class is used to display AddressModel
    /// </summary>
    public class AddressModel
    {
        /// <summary>
        /// used to display Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// used to display Address
        /// </summary>
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }
        /// <summary>
        /// used to display City
        /// </summary>
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }
        /// <summary>
        /// used to display PostCode
        /// </summary>
        [Required(ErrorMessage = "PostCode is required.")]
        public string PostCode { get; set; }
        /// <summary>
        /// used to display Country
        /// </summary>
        [Required(ErrorMessage = "Country is required.")]
        public string County { get; set; }
        /// <summary>
        /// used to display Name
        /// </summary>
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        /// <summary>
        /// used to display Phoneno.
        /// </summary>
        public string PhoneNo { get; set; }
    }
}
