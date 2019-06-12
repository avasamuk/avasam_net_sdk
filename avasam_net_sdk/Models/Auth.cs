using avasam_net_sdk.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models
{
    public class Auth : BaseContext
    {
        public Auth(LoginResponse apiContext) : base(apiContext)
        {
        }
        public async Task<LoginResponse> Login(string Email, string Password)
        {
            return await Post<LoginResponse>("api/Signup/Login", (new LoginRequest() {
                Email = Email,
                Password = Password
            }).ToJson());
        }

    
    }
}
