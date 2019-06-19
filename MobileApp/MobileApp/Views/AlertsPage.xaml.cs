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
    public partial class AlertsPage : ContentPage
    {
        public AlertsPage()
        {
            InitializeComponent();
            
        }

        private void Message_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("The Title", "Hello World!", "Ok");
        }
        private async void YesNo_Clicked(object sender, EventArgs e)
        {
            var result = await  DisplayAlert("The Title", "Hello World!", "Ok","Cancel");
            Debug.WriteLine(result);
        }
    }
}