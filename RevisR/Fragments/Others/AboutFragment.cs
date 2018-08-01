using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RevisR.Fragments.Others
{
    class AboutFragment : Fragment
    {
        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.home, container, false);
            return view;
        }
    }
}