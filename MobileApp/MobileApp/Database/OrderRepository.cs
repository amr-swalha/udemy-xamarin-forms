using MobileApp.Models;
using System.Collections.Generic;

namespace MobileApp.Database
{
    public class OrderRepository : Context<Order>
    {
        public override List<Order> GetAll() => connection.Table<Order>().ToList();
    }
}
