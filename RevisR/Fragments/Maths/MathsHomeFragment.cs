﻿using Android.App;
using Android.OS;
using Android.Views;
using System;

namespace RevisR.Fragments.Maths
{
    public class MathsHomeFragment : Fragment
    {
        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.maths_home, container, false);

            var openMathsDefineButton = view.FindViewById(Resource.Id.showDefinitions);
            openMathsDefineButton.Click += (object sender, EventArgs e) =>
            {
                openMathsDefinitions(sender, e);
            };

            return view;
        }

        public void openMathsDefinitions(object sender, EventArgs e)
        {
            Fragment fragment = new Pages.MathsDefinitionsFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }
    }
}