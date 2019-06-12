using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    /// OrdersCreationController.cs
    /// <summary>
    /// This class is used to display GeneralInfoModel
    /// </summary>
    public class GeneralInfoModel
    {
        /// <summary>
        ///  used to display Reference Number
        /// </summary>
        public string ReferenceNum { get; set; }
        /// <summary>
        ///  used to display External reference number
        /// </summary>
        public string ExternalReferenceNum { get; set; }
        /// <summary>
        ///  used to display received date
        /// </summary>
        public string ReceivedDate { get; set; }
        /// <summary>
        ///  used to display source
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// used to display SubSource
        /// </summary>
        public string SubSource { get; set; }
    }
}
