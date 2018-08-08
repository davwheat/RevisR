﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Content.PM;

namespace RevisR
{
    [Activity(Theme = "@style/AppTheme.Splash", MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var mainIntent = new Intent(Application.Context, typeof(MainActivity));

            if (Intent.Extras != null)
            {
                mainIntent.PutExtras(Intent.Extras);
            }
            mainIntent.SetFlags(ActivityFlags.SingleTop);

            StartActivity(mainIntent);
        }
        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}