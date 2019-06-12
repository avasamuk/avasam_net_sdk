using System;
using System.Collections.Generic;
using System.Text;

namespace avasam_net_sdk.Models.Classes
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
    }
}
