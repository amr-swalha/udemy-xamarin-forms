using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EssentialsPage : ContentPage
    {
        public EssentialsPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var level = Battery.ChargeLevel;
        }

        private void ShareBtn_Clicked(object sender, EventArgs e)
        {
            Share.RequestAsync(new ShareTextRequest { Text = "Share Link", Uri = "https://google.com" });
        }
    }
}