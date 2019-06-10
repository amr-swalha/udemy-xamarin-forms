using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.Views
{
    public class FeedSearchHandler : SearchHandler
    {
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            if (string.IsNullOrEmpty(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                var results = new List<Results>();
                results.Add(new Results { Text = "Hello", Description = "Desc" });
                ItemsSource = results;
            }
        }
        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            Debug.WriteLine(item.ToString());
        }
    }

    public class Results
    {
        public string Text { get; set; }
        public string Description { get; set; }
    }

}
