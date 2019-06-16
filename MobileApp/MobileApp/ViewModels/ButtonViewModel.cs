using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class ButtonViewModel : BaseViewModel
    {
        public ButtonViewModel(string lblText)
        {
            Title = "Button Page";
            LblText = lblText;
            ButtonCommand = new Command(() =>
            {
                Debug.WriteLine("WriteLine from command");
            });
            NotifyCommand = new Command(() =>
            {
                NotifyTxt = "Value is updated";
            });
        }
        public string Title { get; set; }
        public string LblText { get; set; }
        private string notifyTxt = "Initial Value";
        public string NotifyTxt
        {
            get { return notifyTxt; }
            set { SetProperty(ref notifyTxt, value); }
        }
        public ICommand ButtonCommand { get; set; }
        public ICommand NotifyCommand { get; set; }

    }
}
