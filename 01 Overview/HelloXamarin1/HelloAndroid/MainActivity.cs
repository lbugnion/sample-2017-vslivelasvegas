using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloAndroid1
{
    [Activity(Label = "HelloAndroid1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int _counter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += (s, e) =>
            {
                var text = FindViewById<TextView>(Resource.Id.MyText);
                text.Text = $"Counter clicked {++_counter} times";
            };
        }
    }
}

