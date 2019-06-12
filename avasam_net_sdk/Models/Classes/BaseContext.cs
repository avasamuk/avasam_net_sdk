using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    public abstract class BaseContext : IBaseContext
    {

        public BaseContext(LoginResponse apiContext)
        {
            this.ApiContext = apiContext;
        }
        private LoginResponse ApiContext { get; set; }
        private string Server = "https://sandbox.avasam.co.uk/";

        public async Task<T> Get<T>(string Url, string Data)
        {
            return await HttpFactory.GetRequest<T>(Server, Url, Data, ApiContext == null ? "" : ApiContext.token);
        }

        public async Task<T> Post<T>(string Url, string Data)
        {
            return await HttpFactory.PostRequest<T>(Server, Url, Data, ApiContext == null ? "" : ApiContext.token);
        }
    }
}
