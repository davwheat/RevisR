using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace RevisR.Fragments.English.Literature
{
    public class EnglishLitPunctuationFragment : Fragment
    {
        private View view;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.english_lit, container, false);

            ((TextView)view.FindViewById(Resource.Id.engLitTechniquesButton)).Click += openEnglishTechniques;

            return view;
        }

        public void openEnglishTechniques(object sender, EventArgs e)
        {
            Fragment fragment = new EnglishLitTechniquesFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }
    }
}