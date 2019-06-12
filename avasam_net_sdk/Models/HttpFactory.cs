using avasam_net_sdk.Models.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace avasam_net_sdk.Models
{
    public class HttpFactory
    {
        
        public static async Task<T> PostRequest<T>(string Server, string Url, string Data, string Token)
        {
            
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(Server + Url);
            Request.Proxy = null;
            Request.ContentType = "application/json";
            Request.Method = "POST";
            if (!String.IsNullOrWhiteSpace(Token))
            {
                Request.Headers.Add("Authorization", Token);
            }
             try
            {
                using (var streamWriter = new StreamWriter(Request.GetRequestStream()))
                {
                    await streamWriter.WriteAsync(Data);
                }

                using (StreamReader reader = new StreamReader(Request.GetResponse().GetResponseStream()))
                {
                    return  (await reader.ReadToEndAsync()).ToJson<T>(); 
                }
            }
             catch (WebException e)
            {
                using (WebResponse response = e.Response)
                { 
                    using (HttpWebResponse httpResp = (HttpWebResponse)response)
                    {
                        using (StreamReader reader = new StreamReader((Stream)httpResp.GetResponseStream()))
                        {
                            string Error = await reader.ReadToEndAsync();
                            throw new Exception(Error);
                        }
                    }
                } 
            }
            
        }

        public static async Task<T> GetRequest<T>(string Server, string Url, string Data, string Token)
        {
             
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(Server + Url + "?" + Data);
            Request.Proxy = null;
            Request.ContentType = "application/json";
            Request.Method = "GET";
            if (!String.IsNullOrWhiteSpace(Token))
            {
                Request.Headers.Add("Authorization", Token);
            }
             try
            { 
                using (StreamReader reader = new StreamReader(Request.GetResponse().GetResponseStream()))
                {
                    return (await reader.ReadToEndAsync()).ToJson<T>();
                }
            }
             catch (WebException e)
            {
                using (WebResponse response = e.Response)
                { 
                    using (HttpWebResponse httpResp = (HttpWebResponse)response)
                    {
                        using (StreamReader reader = new StreamReader((Stream)httpResp.GetResponseStream()))
                        {
                            string Error =await reader.ReadToEndAsync();
                            throw new Exception(Error);
                        }
                    }
                } 
            }
             
        }
    }
}
