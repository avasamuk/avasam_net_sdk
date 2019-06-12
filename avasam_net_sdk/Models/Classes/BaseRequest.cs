using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace avasam_net_sdk.Models.Classes
{
    /// <summary>
    /// This class used for all supplier details save time using
    /// </summary>
   public class BaseRequest
    {
        /// <summary>
        /// supplier authkey
        /// </summary>
        public string authkey { get; set; }
        /// <summary>
        /// supplier shipper id
        /// </summary>
        public string shipperid { get; set; }
        /// <summary>
        /// customer seeker id
        /// </summary>
        public string seekerid { get; set; }
    }
}
