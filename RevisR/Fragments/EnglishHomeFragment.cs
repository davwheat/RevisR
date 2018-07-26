using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace RevisR
{
    public class EnglishHomeFragment : Fragment
    {
        private View view;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.english_home, container, false);

            ((TextView)view.FindViewById(Resource.Id.engOpenLang)).Click += openEngLangMethod;
            ((TextView)view.FindViewById(Resource.Id.engOpenLit)).Click += openEngLitMethod;

            return view;
        }

        public void openEngLangMethod(object sender, EventArgs e)
        {
            Fragment fragment = new EnglishLangHomeFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        public void openEngLitMethod(object sender, EventArgs e)
        {
            Fragment fragment = new EnglishLitHomeFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }
    }
}