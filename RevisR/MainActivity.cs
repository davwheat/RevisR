﻿using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;

namespace RevisR
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            var drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            var toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
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

        protected override void OnSaveInstanceState(Bundle savedInstanceState)
        {
            //save current fragment index
        }

        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            //save current fragment index
        }

        public override void OnBackPressed()
        {
            var drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if (drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

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
                closeApplication();
            }

            return base.OnOptionsItemSelected(item);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            var id = item.ItemId;
            Fragment fragment = null;

            switch (id)
            {
                default:
                    break;

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
                    break;

                case Resource.Id.nav_history:
                    break;

                case Resource.Id.nav_share:
                    break;

                case Resource.Id.nav_send:
                    break;
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
                Snackbar.Make(FindViewById(Android.Resource.Id.Content), "Not currently supported", 0).Show();
            }
            return false;
        }

        public static void closeApplication()
        {
            Process.KillProcess(Process.MyPid());
        }
    }
}