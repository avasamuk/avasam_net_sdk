using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace avasam_net_sdk.Models.Classes
{
    public static class JsonSerialize
    {
        public static T ToJson<T>(this string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }

        public static string ToJson<T>(this T data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}
