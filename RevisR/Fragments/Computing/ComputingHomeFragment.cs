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
            Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Feedback", (v) => { try { using (var intent = new Android.Content.Intent(Android.Content.Intent.ActionSendto, Android.Net.Uri.Parse("mailto:"))) { StartActivity(Android.Content.Intent.CreateChooser(intent.PutExtra(Android.Content.Intent.ExtraEmail, new string[] { Localisation.feedbackEmail }).PutExtra(Android.Content.Intent.ExtraSubject, Localisation.feedbackSubject).PutExtra(Android.Content.Intent.ExtraText, Localisation.feedbackBody).SetType("message/rfc822"), "Please select an email client...")); } } catch (Android.Content.ActivityNotFoundException ex) { Toast.MakeText(Context, "There are no email clients installed", ToastLength.Long).Show(); } }).SetActionTextColor(Android.Graphics.Color.SteelBlue).Show();
        }

        public void openComputingOperatingSystems(object sender, EventArgs e)
        {
            //Fragment fragment = new Hardware.ComputingHardwareFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Feedback", (v) => { try { using (var intent = new Android.Content.Intent(Android.Content.Intent.ActionSendto, Android.Net.Uri.Parse("mailto:"))) { StartActivity(Android.Content.Intent.CreateChooser(intent.PutExtra(Android.Content.Intent.ExtraEmail, new string[] { Localisation.feedbackEmail }).PutExtra(Android.Content.Intent.ExtraSubject, Localisation.feedbackSubject).PutExtra(Android.Content.Intent.ExtraText, Localisation.feedbackBody).SetType("message/rfc822"), "Please select an email client...")); } } catch (Android.Content.ActivityNotFoundException ex) { Toast.MakeText(Context, "There are no email clients installed", ToastLength.Long).Show(); } }).SetActionTextColor(Android.Graphics.Color.SteelBlue).Show();
        }

        public void openComputingBinary(object sender, EventArgs e)
        {
            //Fragment fragment = new Hardware.ComputingHardwareFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Feedback", (v) => { try { using (var intent = new Android.Content.Intent(Android.Content.Intent.ActionSendto, Android.Net.Uri.Parse("mailto:"))) { StartActivity(Android.Content.Intent.CreateChooser(intent.PutExtra(Android.Content.Intent.ExtraEmail, new string[] { Localisation.feedbackEmail }).PutExtra(Android.Content.Intent.ExtraSubject, Localisation.feedbackSubject).PutExtra(Android.Content.Intent.ExtraText, Localisation.feedbackBody).SetType("message/rfc822"), "Please select an email client...")); } } catch (Android.Content.ActivityNotFoundException ex) { Toast.MakeText(Context, "There are no email clients installed", ToastLength.Long).Show(); } }).SetActionTextColor(Android.Graphics.Color.SteelBlue).Show();
        }

        public void openComputingHexadecimal(object sender, EventArgs e)
        {
            //Fragment fragment = new Hardware.ComputingHardwareFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Feedback", (v) => { try { using (var intent = new Android.Content.Intent(Android.Content.Intent.ActionSendto, Android.Net.Uri.Parse("mailto:"))) { StartActivity(Android.Content.Intent.CreateChooser(intent.PutExtra(Android.Content.Intent.ExtraEmail, new string[] { Localisation.feedbackEmail }).PutExtra(Android.Content.Intent.ExtraSubject, Localisation.feedbackSubject).PutExtra(Android.Content.Intent.ExtraText, Localisation.feedbackBody).SetType("message/rfc822"), "Please select an email client...")); } } catch (Android.Content.ActivityNotFoundException ex) { Toast.MakeText(Context, "There are no email clients installed", ToastLength.Long).Show(); } }).SetActionTextColor(Android.Graphics.Color.SteelBlue).Show();
        }
    }
}