using MobileApp.Database;
using MobileApp.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MobileApp.ViewModels
{
    public class DatabaseViewModel : BaseViewModel
    {
        private readonly OrderRepository _order;
        public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
        public DatabaseViewModel()
        {
            _order = new OrderRepository();
            foreach (var item in _order.GetAll())
            {
                Orders.Add(item);
            }
            
        }
        public void AddItem(Order order)
        {
            _order.Insert(order);
            Orders.Add(order);
        }
    }
}
