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
    public partial class DepedencyExample : ContentPage
    {
        public DepedencyExample()
        {
            InitializeComponent();
        }

        private void ServiceBtn_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<ISampleService>().SampleMethod();
        }
    }
}