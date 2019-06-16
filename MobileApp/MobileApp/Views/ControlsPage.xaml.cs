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
    public partial class ControlsPage : ContentPage
    {
        public ControlsPage()
        {
            InitializeComponent();
        }

        private void DatepickerCtrl_DateSelected(object sender, DateChangedEventArgs e)
        {
            Debug.WriteLine(datepickerCtrl.Date);
        }
    }
}