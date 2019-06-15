using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class ButtonViewModel
    {
        public ButtonViewModel(string lblText)
        {
            Title = "Button Page";
            LblText = lblText;
            ButtonCommand = new Command(() => {
                Debug.WriteLine("WriteLine from command");
            });
        }
        public string Title { get; set; }
        public string LblText { get; set; }
        public ICommand ButtonCommand { get; set; }
    }
}
