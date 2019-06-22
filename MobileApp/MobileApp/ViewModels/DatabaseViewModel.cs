using MobileApp.Database;
using MobileApp.Models;

namespace MobileApp.ViewModels
{
    public class DatabaseViewModel : BaseViewModel
    {
        public OrderRepository _order;
        public DatabaseViewModel()
        {
            _order = new OrderRepository();
            _order.Insert(new Order { Amount = 50, CustomerName = "Ahmad" });
            var data = _order.GetAll();

        }
    }
}
