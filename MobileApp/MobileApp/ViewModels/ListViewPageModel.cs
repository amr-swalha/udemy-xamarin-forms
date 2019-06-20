using MobileApp.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MobileApp.ViewModels
{
    public class ListViewPageModel : BaseViewModel
    {
        public ObservableCollection<Order> orders { get; set; }
        public ListViewPageModel()
        {
            orders = new ObservableCollection<Order>();
            orders.Add(new Order { CustomerName = "Joe", Amount = 20 });
            orders.Add(new Order { CustomerName = "David", Amount = 30 });
        }
    }
}
