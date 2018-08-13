using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

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

            var ad = AdMob.AdMobFunctions.getBannerAd(Context);
            if (ad != null) // Will return null if Ads are disabled
                view.FindViewById<LinearLayout>(Resource.Id.homeFragmentLinearLayout).AddView(ad);

            view.SetOnKeyListener(new IDisableBackOnKeyListener(view));
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
            Common.notImplementedWarning(view, Context);
        }

        private void openGeography(object sender, System.EventArgs e)
        {
            //Fragment fragment = new HomeFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Common.notImplementedWarning(view, Context);
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