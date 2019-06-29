using System;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessagingCenterExample : ContentPage
    {
        public MessagingCenterExample()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<MessagingCenterExample>(this, "Test", (sender) => {
                Debug.WriteLine("Messages has been received");
            });
        }

        private void CallBtn_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "Test");
        }
    }
}