using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace androidTest
{
    [Activity(Label = "androidTest", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        { 
            base.OnCreate(savedInstanceState);

            AppCenter.Start("60c350e3-3deb-473e-8e8f-8d70e53d4477", typeof(Analytics), typeof(Crashes));

            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate
            {
                button.Text = "hehe xd";
            };
        }
    }
}

