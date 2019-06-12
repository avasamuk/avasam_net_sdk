using avasam_net_sdk.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models
{
    public class ApiObjectExplorer
    {
        private LoginResponse LoginInfo;

        public ApiObjectExplorer(LoginResponse LoginInfo)
        {
            this.LoginInfo = LoginInfo;
        }

        private Auth _auth;
        private Orders _Orders;
        private Products _Products;

        public Auth Auth
        {
            get
            {
                return _auth ?? (_auth = new Auth(LoginInfo));
            }
        }

        public async Task<LoginResponse> Login(string Email, string Password)
        {
            LoginInfo = await Auth.Login(Email, Password);
            return LoginInfo;
        }

        public Orders Orders {
            get { return _Orders ?? (_Orders = new Orders(LoginInfo)); }
        }

        public Products Products
        {
            get { return _Products ?? (_Products = new Products(LoginInfo)); }
        }
    }
}
