using avasam_net_sdk.Models;
using System;

namespace avasam_net_sdk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avasam Sample API Call");

            //First Login with avasam using your user name and password. For supplier we recommended create api user separately from Settings -> User Management
            string Email = ""; //Your user email address
            string Password = ""; //Your user password
            ApiObjectExplorer api = new ApiObjectExplorer(null); 
            var loginResp = api.Login(Email, Password).Result;


            //Now call api for get all orders
            var orders = api.Orders.GetOrders(new Models.Classes.GetOrdersRequest() {
                limit = 10,
                supplier = loginResp.authkey,
                OrderNumber = "",
                page = 1
            });
            Console.ReadLine();
        }
    }
}
