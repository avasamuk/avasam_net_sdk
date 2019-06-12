using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models.Classes
{
    public interface IBaseContext
    {
        Task<T> Post<T>(string Url, string Data);
        Task<T> Get<T>(string Url, string Data);
    }
}
