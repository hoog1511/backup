using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Text;

namespace AndroidTimePicker
{
    [Activity(Label = "AndroidTimePicker", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        TimePicker timePicker;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            timePicker = FindViewById<TimePicker>(Resource.Id.timePicker);
            var btnChange = FindViewById<Button>(Resource.Id.btnChange);
            var txtDisplay = FindViewById<TextView>(Resource.Id.txtDisplay);
            btnChange.Click += (s, e) => {
                txtDisplay.Text = getTime();
            };
            timePicker.SetIs24HourView(Java.Lang.Boolean.True);
            txtDisplay.Text = getTime();
          
        }

        private string getTime()
        {
            StringBuilder strTime = new StringBuilder();
            strTime.Append("Time: " + timePicker.CurrentHour + ":" + timePicker.CurrentMinute);
            return strTime.ToString();
        }
    }
}

