using MobileApp.iOS;
using System.Diagnostics;
using Xamarin.Forms;

[assembly: Dependency(typeof(SampleService))]
namespace MobileApp.iOS
{
    public class SampleService : ISampleService
    {
        public void SampleMethod()
        {
            Debug.WriteLine("This is iOS code");
        }
    }
}