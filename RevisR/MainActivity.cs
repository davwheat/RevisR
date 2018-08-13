using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Firebase.Messaging;
using Firebase.Iid;
using Android.Util;
using Android.Gms.Ads;
using Android.Widget;
using Android.Support.V4.App;
using System;
using Android;

namespace RevisR
{
#if DEBUG
    [Activity(Label = "@string/app_name_debug", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, LaunchMode = Android.Content.PM.LaunchMode.SingleTop, NoHistory = true)]
#else
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, LaunchMode = Android.Content.PM.LaunchMode.SingleTop, NoHistory = true)]
#endif
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        private const string TAG = nameof(MainActivity);
        public const int NOTIFICATION_ID = 1;
        public const string CHANNEL_ID = "General";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            
            if (Intent.Extras != null)
            {
                foreach (var key in Intent.Extras.KeySet())
                {
                    var value = Intent.Extras.GetString(key);
#if DEBUG
                    Log.Debug(TAG, "Key: {0} Value: {1}", key, value);
#endif
                }
            }

            // Check if play services are installed
            var playservices = Firebase.FirebaseFunctions.IsGooglePlayServicesInstalled(this);
            if (!playservices.Item1) // If services NOT available
            {
                // Inform user their device cannot run this app and force quit
                Common.showAlertDialog(this, "Play Services", "The Google Play Services are not available.\n\nThis app cannot be run on this device.", Common.AlertDialogButton.Exit, () => Common.closeApplication());
            }
            else
            {
                if (Android.Support.V4.Content.ContextCompat.CheckSelfPermission(this, Manifest.Permission.AccessFineLocation) != Android.Content.PM.Permission.Granted && ActivityCompat.CheckSelfPermission(this, Manifest.Permission.AccessCoarseLocation) != Android.Content.PM.Permission.Granted)
                {
                    Common.showAlertDialog(this, "Permissions", "This app uses your Location to show more relevant advertising. We don't use your location for anything else at the moment, and we will always ask you if we ever decide to.\n\nFeel free to deny the permission -- we don't mind!", Common.AlertDialogButton.Ok, () => ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.AccessFineLocation }, 1));
                }
                
                // Initialise AdMob
                AdMob.AdMobFunctions.Initialise(this);

                var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
                SetSupportActionBar(toolbar);

                var drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
                var toggle = new Android.Support.V7.App.ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
                drawer.AddDrawerListener(toggle);
                toggle.SyncState();

                var navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
                navigationView.SetNavigationItemSelectedListener(this);

                var fragment = new Fragments.HomeFragment();
                var fragmentTransaction = FragmentManager.BeginTransaction();
                fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
                fragmentTransaction.AddToBackStack(null);
                fragmentTransaction.Commit();
            }
        }

        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);
        }

        //public override void OnBackPressed()
        //{
        //    var drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
        //    if (drawer.IsDrawerOpen(GravityCompat.Start))
        //    {
        //        drawer.CloseDrawer(GravityCompat.Start);
        //    }
        //    else
        //    {
        //        var currentFragment = SupportFragmentManager.FindFragmentById(Resource.Id.home);
        //        if (currentFragment is Fragments.HomeFragment.IBackButtonListener listener)
        //        {
        //            listener.OnBackPressed();
        //            return;
        //        }
        //        else
        //        {
        //            base.OnBackPressed();
        //        }
        //    }
        //}

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            var id = item.ItemId;
            if (id == Resource.Id.action_exit)
            {
                Common.closeApplication();
            }
            else if (id == Resource.Id.action_home)
            {
                goHome();
            }

            return base.OnOptionsItemSelected(item);
        }

        public void goHome()
        {
            var fragment = new Fragments.HomeFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            var id = item.ItemId;
            Android.App.Fragment fragment = null;

            switch (id)
            {
                case Resource.Id.nav_home:
                    fragment = new Fragments.HomeFragment();
                    break;

                case Resource.Id.nav_english:
                    fragment = new Fragments.English.EnglishHomeFragment();
                    break;

                case Resource.Id.nav_maths:
                    fragment = new Fragments.Maths.MathsHomeFragment();
                    break;

                case Resource.Id.nav_geography:
                case Resource.Id.nav_history:
                case Resource.Id.nav_share:
                case Resource.Id.nav_about:
                    break;

                case Resource.Id.nav_computing:
                    fragment = new Fragments.Computing.ComputingHomeFragment();
                    break;

                case Resource.Id.nav_feedback:
                    Common.sendFeedback(Application.ApplicationContext);
                    return false;

                case Resource.Id.nav_discord:
                    Common.openDiscordServer(Application.ApplicationContext);
                    return false;
            }

            if (fragment != null)
            {
                //home_fragment
                var fragmentTransaction = FragmentManager.BeginTransaction();
                fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
                fragmentTransaction.AddToBackStack(null);
                fragmentTransaction.Commit();

                var drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
                drawer.CloseDrawer(GravityCompat.Start);
                return true;
            }
            else
            {
                Common.notImplementedWarning(FindViewById(Android.Resource.Id.Content), ApplicationContext);
                return false;
            }
        }
    }
}