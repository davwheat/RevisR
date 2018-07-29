using System;

using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;

namespace RevisR.Fragments.Computing
{
    class ComputingHomeFragment : Fragment
    {
        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.computing_home, container, false);

            ((TextView)view.FindViewById(Resource.Id.computingHardwareButton)).Click += openComputingHardware;
            ((TextView)view.FindViewById(Resource.Id.computingSoftwareButton)).Click += openComputingSoftware;
            ((TextView)view.FindViewById(Resource.Id.computingOsButton)).Click += openComputingOperatingSystems;
            ((TextView)view.FindViewById(Resource.Id.computingBinaryButton)).Click += openComputingBinary;
            ((TextView)view.FindViewById(Resource.Id.computingHexadecimalButton)).Click += openComputingHexadecimal;

            return view;
        }

        public void openComputingHardware(object sender, EventArgs e)
        {
            Fragment fragment = new Hardware.ComputingHardwareFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        public void openComputingSoftware(object sender, EventArgs e)
        {
            //Fragment fragment = new Hardware.ComputingHardwareFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Android.Support.Design.Widget.Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Feedback", (v) => {
                var intent = new Android.Content.Intent(Android.Content.Intent.ActionSendto, Android.Net.Uri.FromParts("mailto", "davidwheatley03@gmail.com", null));
                intent.PutExtra(Android.Content.Intent.ExtraSubject, "RevisR Feedback");
                intent.PutExtra(Android.Content.Intent.ExtraText, "Please type your feedback here.");

                try
                {
                    StartActivity(Android.Content.Intent.CreateChooser(intent, "Send mail..."));
                }
                catch (Android.Content.ActivityNotFoundException ex)
                {
                    Toast.MakeText(Context, "There are no email clients installed", ToastLength.Long).Show();
                }
            }).SetActionTextColor(Android.Graphics.Color.SteelBlue).Show();
        }

        public void openComputingOperatingSystems(object sender, EventArgs e)
        {
            //Fragment fragment = new Hardware.ComputingHardwareFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Android.Support.Design.Widget.Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Feedback", (v) => {
                var intent = new Android.Content.Intent(Android.Content.Intent.ActionSendto, Android.Net.Uri.FromParts("mailto", "davidwheatley03@gmail.com", null));
                intent.PutExtra(Android.Content.Intent.ExtraSubject, "RevisR Feedback");
                intent.PutExtra(Android.Content.Intent.ExtraText, "Please type your feedback here.");

                try
                {
                    StartActivity(Android.Content.Intent.CreateChooser(intent, "Send mail..."));
                }
                catch (Android.Content.ActivityNotFoundException ex)
                {
                    Toast.MakeText(Context, "There are no email clients installed", ToastLength.Long).Show();
                }
            }).SetActionTextColor(Android.Graphics.Color.SteelBlue).Show();
        }

        public void openComputingBinary(object sender, EventArgs e)
        {
            //Fragment fragment = new Hardware.ComputingHardwareFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Android.Support.Design.Widget.Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Feedback", (v) => {
                var intent = new Android.Content.Intent(Android.Content.Intent.ActionSendto, Android.Net.Uri.FromParts("mailto", "davidwheatley03@gmail.com", null));
                intent.PutExtra(Android.Content.Intent.ExtraSubject, "RevisR Feedback");
                intent.PutExtra(Android.Content.Intent.ExtraText, "Please type your feedback here.");

                try
                {
                    StartActivity(Android.Content.Intent.CreateChooser(intent, "Send mail..."));
                }
                catch (Android.Content.ActivityNotFoundException ex)
                {
                    Toast.MakeText(Context, "There are no email clients installed", ToastLength.Long).Show();
                }
            }).SetActionTextColor(Android.Graphics.Color.SteelBlue).Show();
        }

        public void openComputingHexadecimal(object sender, EventArgs e)
        {
            //Fragment fragment = new Hardware.ComputingHardwareFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Android.Support.Design.Widget.Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Feedback", (v) => {
                var intent = new Android.Content.Intent(Android.Content.Intent.ActionSendto, Android.Net.Uri.FromParts("mailto", "davidwheatley03@gmail.com", null));
                intent.PutExtra(Android.Content.Intent.ExtraSubject, "RevisR Feedback");
                intent.PutExtra(Android.Content.Intent.ExtraText, "Please type your feedback here.");

                try
                {
                    StartActivity(Android.Content.Intent.CreateChooser(intent, "Send mail..."));
                }
                catch (Android.Content.ActivityNotFoundException ex)
                {
                    Toast.MakeText(Context, "There are no email clients installed", ToastLength.Long).Show();
                }
            }).SetActionTextColor(Android.Graphics.Color.SteelBlue).Show();
        }
    }
}