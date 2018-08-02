using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace RevisR.Fragments.English.Literature
{
    public class EnglishLitHomeFragment : Fragment
    {
        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.english_lit, container, false);

            ((TextView)view.FindViewById(Resource.Id.engLitTechniquesButton)).Click += openEnglishTechniques;
            ((TextView)view.FindViewById(Resource.Id.engLitPunctuationButton)).Click += openEnglishPunctuation;

            return view;
        }

        public void openEnglishTechniques(object sender, EventArgs e)
        {
            Fragment fragment = new Pages.EnglishLitTechniquesFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        public void openEnglishPunctuation(object sender, EventArgs e)
        {
            Fragment fragment = new Pages.EnglishLitPunctuationFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }
    }
}