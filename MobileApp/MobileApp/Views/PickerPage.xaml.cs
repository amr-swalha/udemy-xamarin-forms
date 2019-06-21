using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerPage : ContentPage
    {
        List<Order> Orders = new List<Order>();
        public PickerPage()
        {
            InitializeComponent();
            Orders.Add(new Order { CustomerName = "Joe", Amount = 100 });
            Orders.Add(new Order { CustomerName = "David", Amount = 300 });
            BindingContext = Orders;
        }

        private void OrdersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var order = (Order)((Picker)sender).SelectedItem;
            Debug.WriteLine(order.Amount);
        }
    }
}