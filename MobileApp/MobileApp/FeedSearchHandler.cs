using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.Controls
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
                results.Add(new Results { Text = "First Item", Description = "Hello" });
                results.Add(new Results { Text = "Second Item", Description = "Description" });
                var data = results.Where(x => x.Text.Trim().ToLower().Contains(newValue.Trim().ToLower())).ToList();
                ItemsSource = data;
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
