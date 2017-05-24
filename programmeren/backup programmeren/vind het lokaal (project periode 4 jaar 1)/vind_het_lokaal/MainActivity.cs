using Android.App;
using Android.Widget;
using Android.OS;

namespace vind_het_lokaal
{
    [Activity(Label = "vind_het_lokaal", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var spinner = FindViewById<Spinner>(Resource.Id.spinner);
            spinner.ItemSelected += (s, e) =>
            {
                string firstitem = spinner.SelectedItem.ToString();
                if (firstitem.Equals(spinner.SelectedItem.ToString()))
                {
                    // To do when first item is selected
                }
                else
                {
                    Toast.MakeText(this, "You have selected: " + e.Parent.GetItemIdAtPosition(e.Position).ToString(), ToastLength.Short).Show();
                }
            };
        }
    }
}