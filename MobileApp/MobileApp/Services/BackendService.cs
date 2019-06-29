using Flurl;
using Flurl.Http;
using MobileApp.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace MobileApp.Services
{
    public class BackendService
    {
        const string ApiAddress = "http://192.168.1.104/udemyxf/api/";
        public List<Order> ListOrders()
        {
            return ApiAddress.AppendPathSegment("orders").GetJsonAsync<List<Order>>().Result;
        }

        public Order SaveOrder(Order order) => 
            ApiAddress.AppendPathSegment("orders").SendJsonAsync(HttpMethod.Post, order).ReceiveJson<Order>().Result;
    }
}
