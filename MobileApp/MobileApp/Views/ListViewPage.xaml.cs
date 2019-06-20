using MobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        ListViewPageModel vm;
        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = vm = new ListViewPageModel();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            vm.orders.Add(new Models.Order { CustomerName = "Customer", Amount = 300 });
        }
    }
}