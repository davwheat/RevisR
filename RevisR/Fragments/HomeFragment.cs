using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using RevisR;

namespace RevisR.Fragments
{
    public class HomeFragment : Fragment
    {
        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.home, container, false);

            ((TextView)view.FindViewById(Resource.Id.home_english)).Click += openEnglish;
            ((TextView)view.FindViewById(Resource.Id.home_maths)).Click += openMaths;
            ((TextView)view.FindViewById(Resource.Id.home_geography)).Click += openGeography;
            ((TextView)view.FindViewById(Resource.Id.home_history)).Click += openHistory;
            ((TextView)view.FindViewById(Resource.Id.home_computing)).Click += openComputing;

            return view;
        }

        private void openComputing(object sender, System.EventArgs e)
        {
            Fragment fragment = new Computing.ComputingHomeFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        private void openHistory(object sender, System.EventArgs e)
        {
            //Fragment fragment = new HomeFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Android.Support.Design.Widget.Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Feedback", (v) => { try { using (var intent = new Android.Content.Intent(Android.Content.Intent.ActionSendto, Android.Net.Uri.Parse("mailto:"))) { StartActivity(Android.Content.Intent.CreateChooser(intent.PutExtra(Android.Content.Intent.ExtraEmail, new string[] { Localisation.feedbackEmail }).PutExtra(Android.Content.Intent.ExtraSubject, Localisation.feedbackSubject).PutExtra(Android.Content.Intent.ExtraText, Localisation.feedbackBody).SetType("message/rfc822"), "Please select an email client...")); } } catch (Android.Content.ActivityNotFoundException ex) { Toast.MakeText(Context, "There are no email clients installed", ToastLength.Long).Show(); } }).SetActionTextColor(Android.Graphics.Color.SteelBlue).Show();
        }

        private void openGeography(object sender, System.EventArgs e)
        {
            //Fragment fragment = new HomeFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Android.Support.Design.Widget.Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Feedback", (v) => { try { using (var intent = new Android.Content.Intent(Android.Content.Intent.ActionSendto, Android.Net.Uri.Parse("mailto:"))) { StartActivity(Android.Content.Intent.CreateChooser(intent.PutExtra(Android.Content.Intent.ExtraEmail, new string[] { Localisation.feedbackEmail }).PutExtra(Android.Content.Intent.ExtraSubject, Localisation.feedbackSubject).PutExtra(Android.Content.Intent.ExtraText, Localisation.feedbackBody).SetType("message/rfc822"), "Please select an email client...")); } } catch (Android.Content.ActivityNotFoundException ex) { Toast.MakeText(Context, "There are no email clients installed", ToastLength.Long).Show(); } }).SetActionTextColor(Android.Graphics.Color.SteelBlue).Show();
        }

        private void openMaths(object sender, System.EventArgs e)
        {
            Fragment fragment = new Maths.MathsHomeFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        private void openEnglish(object sender, System.EventArgs e)
        {
            Fragment fragment = new English.EnglishHomeFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }
    }
}