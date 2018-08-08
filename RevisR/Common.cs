using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;
using System;

namespace RevisR
{
    class Common
    {
        public static void fillListView(ExpandableListView elv, List<string> headings, List<List<string>> textContent, Context context, Dictionary<int, int> images = null)
        {
            // Create dictionary with expandablelistview data
            var data = new Dictionary<string, List<string>>();
            // Add the data to the dictionary
            foreach (var i in headings) { data.Add(i, textContent[headings.IndexOf(i)]); }

            // Create ELV adapter using homebrewed class
            IExpandableListAdapter adapter = new CustomExpandableListAdaptor(context, headings, data, images);
            // Set the adapter
            elv.SetAdapter(adapter);
        }

        public static void notImplementedWarning(View view, Context context)
        {
            showSnackbar(view, Localisation.snackbarComingSoon, () => sendFeedback(context), "Send Feedback");
        }

        public static void sendFeedback(Context context)
        {
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
        }

        public static void showToast(Context context, string text, ToastLength length)
        {
            Toast.MakeText(context, text, length).Show();
        }

        public static void showSnackbar(View view, string text)
        {
            Snackbar.Make(view, text, 0)
                .Show();
        }

        public static void showSnackbar(View view, string text, Action action, string actiontext)
        {
            if (action == null)
            {
                throw new InvalidSnackBarActionException("Action was null at runtime.");
            }

            Snackbar.Make(view, text, 0)
                .SetAction(actiontext, (v) => { action(); })
                .SetActionTextColor(Android.Graphics.Color.ParseColor("#bc097a"))
                .Show();
        }

        public static void showSnackbar(View view, string text, Action action, string actiontext, Android.Graphics.Color snackbarActionTextColor)
        {
            if (action == null)
            {
                throw new InvalidSnackBarActionException("Action was null at runtime.");
            }

            Snackbar.Make(view, text, 0)
                .SetAction(actiontext, (v) => { action(); })
                .SetActionTextColor(snackbarActionTextColor)
                .Show();
        }

        public static void showSnackbar(View view, string text, Action action, string actiontext, string snackbarActionTextColor)
        {
            if (action == null)
            {
                throw new InvalidSnackBarActionException("Action was null at runtime.");
            }

            Snackbar.Make(view, text, 0)
                .SetAction(actiontext, (v) => { action(); })
                .SetActionTextColor(Android.Graphics.Color.ParseColor(snackbarActionTextColor))
                .Show();
        }

        public static void openDiscordServer(Context context) {
            var browserIntent = new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://discord.gg/zjJtMxu"));
            context.StartActivity(browserIntent);
        }

        [Serializable]
        public class InvalidSnackBarActionException : Exception
        {
            public InvalidSnackBarActionException() { }
            public InvalidSnackBarActionException(string message) : base(message) { }
            public InvalidSnackBarActionException(string message, Exception inner) : base(message, inner) { }
            protected InvalidSnackBarActionException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}
