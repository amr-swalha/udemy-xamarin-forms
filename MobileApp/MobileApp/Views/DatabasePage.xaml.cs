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
            vm = new DatabaseViewModel();
            var data = vm._order.GetAll();
            for (int i = 0; i < 8; i++)
            {

            }
        }
    }
}