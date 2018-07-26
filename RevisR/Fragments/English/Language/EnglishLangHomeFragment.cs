using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace RevisR.Fragments.English.Language
{
    public class EnglishLangHomeFragment : Fragment
    {
        private View view;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

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
            Fragment fragment = new EnglishLangPaper1aFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        public void openPaper1b(object sender, EventArgs e)
        {
            Fragment fragment = new EnglishLangPaper1bFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        public void openPaper2a(object sender, EventArgs e)
        {
            Fragment fragment = new EnglishLangPaper2aFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        public void openPaper2b(object sender, EventArgs e)
        {
            Fragment fragment = new EnglishLangPaper2bFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }
    }
}