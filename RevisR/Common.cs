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
using Android.Support.Design.Widget;

namespace RevisR
{
    class Common
    {
        public static void fillListView(ExpandableListView elv, List<string> headings, List<List<string>> textContent, Context context)
        {
            // Create dictionary with expandablelistview data
            var data = new Dictionary<string, List<string>>();
            // Add the data to the dictionary
            foreach (var i in headings) { data.Add(i, textContent[headings.IndexOf(i)]); }

            // Create ELV adapter using homebrewed class
            IExpandableListAdapter adapter = new CustomExpandableListAdaptor(context, headings, data);
            // Set the adapter
            elv.SetAdapter(adapter);
        }

        public static void notImplementedWarning(View view, Context context)
        {
            Snackbar.Make(view, Localisation.snackbarComingSoon, 0).SetAction("Send Feedback", (v) => {
                var intent = new Intent(Intent.ActionSendto, Android.Net.Uri.FromParts("mailto", "davidwheatley03@gmail.com", null));
                intent.PutExtra(Intent.ExtraSubject, "RevisR Feedback");
                intent.PutExtra(Intent.ExtraText, "Please type your feedback here.");

                try
                {
                    context.StartActivity(Intent.CreateChooser(intent, "Send mail..."));
                }
                catch (ActivityNotFoundException)
                {
                    Toast.MakeText(context, "There are no email clients installed", ToastLength.Long).Show();
                }
            }).SetActionTextColor(Android.Graphics.Color.DarkTurquoise).Show();
        }
    }
}