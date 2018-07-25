using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace RevisR
{

    public class EnglishLangFragment : Fragment
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

    public class EnglishLangPaper1aFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.english_paper1a, container, false);
        }
    }

    public class EnglishLangPaper1bFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.english_paper1b, container, false);
        }
    }

    public class EnglishLangPaper2aFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.english_paper2a, container, false);
        }
    }

    public class EnglishLangPaper2bFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.english_paper2b, container, false);
        }
    }
}