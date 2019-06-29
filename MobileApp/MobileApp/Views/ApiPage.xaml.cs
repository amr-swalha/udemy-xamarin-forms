using MobileApp.Models;
using MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApiPage : ContentPage
    {
        BackendService backendService;
        public ObservableCollection<Order> orders;
        public ApiPage()
        {
            InitializeComponent();
            backendService = new BackendService();
            orders = new ObservableCollection<Order>();
            BindingContext = orders;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            orders.Clear();
            foreach (var item in backendService.ListOrders())
            {
                orders.Add(item);
            }
        }

        private void SaveData_Clicked(object sender, EventArgs e)
        {
            var data = backendService.SaveOrder(new Order { CustomerName = CustomerName.Text, Amount = int.Parse(Amount.Text) });
        }
    }
}