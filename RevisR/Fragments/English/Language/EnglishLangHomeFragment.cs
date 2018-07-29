using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace RevisR.Fragments.English.Language
{
    public class EnglishLangHomeFragment : Fragment
    {
        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.english_lang, container, false);

            ((TextView)view.FindViewById(Resource.Id.engLangPaper1aButton)).Click += openPaper1a;
            ((TextView)view.FindViewById(Resource.Id.engLangPaper1bButton)).Click += openPaper1b;
            ((TextView)view.FindViewById(Resource.Id.engLangPaper2aButton)).Click += openPaper2a;
            ((TextView)view.FindViewById(Resource.Id.engLangPaper2bButton)).Click += openPaper2b;

            return view;
        }

        public void openPaper1a(object sender, EventArgs e)
        {
            Fragment fragment = new Pages.Papers.EnglishLangPaper1aFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        public void openPaper1b(object sender, EventArgs e)
        {
            Fragment fragment = new Pages.Papers.EnglishLangPaper1bFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        public void openPaper2a(object sender, EventArgs e)
        {
            //Fragment fragment = new Pages.Papers.EnglishLangPaper2aFragment();
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

        public void openPaper2b(object sender, EventArgs e)
        {
            //Fragment fragment = new Pages.Papers.EnglishLangPaper2bFragment();
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