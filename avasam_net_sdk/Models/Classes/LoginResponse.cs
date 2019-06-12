using System;
using System.Collections.Generic;
using System.Text;

namespace avasam_net_sdk.Models.Classes
{
    public class LoginResponse
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public string ClientID { get; set; }
        public string businessname { get; set; }
        public string authkey { get; set; }
        public string token { get; set; }
        public bool IsEnableProductCreation { get; set; }
        public string Action { get; set; }
    }
}
