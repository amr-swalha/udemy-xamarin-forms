using MobileApp.Models;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatabasePage : ContentPage
    {
        DatabaseViewModel vm;

        public DatabasePage()
        {
            InitializeComponent();
            BindingContext = vm = new DatabaseViewModel();
        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            vm.AddItem(new Order { Amount = int.Parse(Amount.Text), CustomerName = CustomerName.Text });
        }
        protected override void OnDisappearing()
        {
            vm = null;
            base.OnDisappearing();
        }
    }
}