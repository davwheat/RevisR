using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;
using System;
using Android.App;

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

        #region Snackbar Overloads

        public static void showSnackbar(View view, string text)
        {
            Snackbar.Make(view, text, 0)
                .Show();
        }

        public static void showSnackbar(View view, string text, Action action, string actiontext)
        {
            Snackbar.Make(view, text, 0)
                .SetAction(actiontext, (v) => { action?.Invoke(); })
                .SetActionTextColor(Android.Graphics.Color.ParseColor("#bc097a"))
                .Show();
        }

        public static void showSnackbar(View view, string text, Action action, string actiontext, Android.Graphics.Color snackbarActionTextColor)
        {
            Snackbar.Make(view, text, 0)
                .SetAction(actiontext, (v) => { action?.Invoke(); })
                .SetActionTextColor(snackbarActionTextColor)
                .Show();
        }

        public static void showSnackbar(View view, string text, Action action, string actiontext, string snackbarActionTextColor)
        {
            Snackbar.Make(view, text, 0)
                .SetAction(actiontext, (v) => { action?.Invoke(); })
                .SetActionTextColor(Android.Graphics.Color.ParseColor(snackbarActionTextColor))
                .Show();
        }

        #endregion

        #region Alert Dialog Overloads

        public enum AlertDialogButton
        {
            Ok = 0,
            Cancel = 1,
            Yes = 2,
            No = 3,
            Apply = 4,
            Save = 5,
            Exit = 6,
        }

        public static void showAlertDialog(Activity activity, string title, string message, AlertDialogButton button1text = AlertDialogButton.Ok)
        {
            using (var dialog = new AlertDialog.Builder(activity))
            {
                var alert = dialog.Create();
                alert.SetTitle(title);
                alert.SetMessage(message);
                var enumToString = new Dictionary<AlertDialogButton, string>
                {
                    { AlertDialogButton.Ok, "OK" },
                    { AlertDialogButton.Cancel, "CANCEL" },
                    { AlertDialogButton.Yes, "YES" },
                    { AlertDialogButton.No, "NO" },
                    { AlertDialogButton.Apply, "APPLY" },
                    { AlertDialogButton.Save, "SAVE" },
                    { AlertDialogButton.Exit, "EXIT" },
                };
                if (enumToString.TryGetValue(button1text, out string button1textstring))
                {
                    alert.SetButton(button1textstring, (c, ev) => { });
                    alert.Show();
                }
                else
                {
                    throw new InvalidOperationException($"{button1text} could not be resolved to a string through the given dictionary when creating the Alert Dialog");
                }
            }
        }

        public static void showAlertDialog(Activity activity, string title, string message, AlertDialogButton button1text, Action button1action)
        {
            using (var dialog = new AlertDialog.Builder(activity))
            {
                var alert = dialog.Create();
                alert.SetTitle(title);
                alert.SetMessage(message);
                var enumToString = new Dictionary<AlertDialogButton, string>
                {
                    { AlertDialogButton.Ok, "OK" },
                    { AlertDialogButton.Cancel, "CANCEL" },
                    { AlertDialogButton.Yes, "YES" },
                    { AlertDialogButton.No, "NO" },
                    { AlertDialogButton.Apply, "APPLY" },
                    { AlertDialogButton.Save, "SAVE" },
                    { AlertDialogButton.Exit, "EXIT" },
                };
                if (enumToString.TryGetValue(button1text, out string button1textstring))
                {
                    alert.SetButton(button1textstring, (c, ev) => { button1action?.Invoke(); });
                    alert.Show();
                }
                else
                {
                    throw new InvalidOperationException($"{button1text} could not be resolved to a string through the given dictionary when creating the Alert Dialog");
                }
            }
        }

        public static void showAlertDialog(Activity activity, string title, string message, AlertDialogButton button1text, Action button1action, AlertDialogButton button2text, Action button2action)
        {
            using (var dialog = new AlertDialog.Builder(activity))
            {
                var alert = dialog.Create();
                alert.SetTitle(title);
                alert.SetMessage(message);
                var enumToString = new Dictionary<AlertDialogButton, string>
                {
                    { AlertDialogButton.Ok, "OK" },
                    { AlertDialogButton.Cancel, "CANCEL" },
                    { AlertDialogButton.Yes, "YES" },
                    { AlertDialogButton.No, "NO" },
                    { AlertDialogButton.Apply, "APPLY" },
                    { AlertDialogButton.Save, "SAVE" },
                    { AlertDialogButton.Exit, "EXIT" },
                };
                if (enumToString.TryGetValue(button1text, out string button1textstring) && enumToString.TryGetValue(button2text, out string button2textstring))
                {
                    alert.SetButton(button1textstring, (c, ev) => { button1action?.Invoke(); });
                    alert.SetButton2(button2textstring, (c, ev) => { button2action?.Invoke(); });
                    alert.Show();
                }
                else
                {
                    throw new InvalidOperationException($"{button1text} or {button2text} could not be resolved to a string through the given dictionary when creating the Alert Dialog");
                }
            }
        }

        public static void showAlertDialog(Activity activity, string title, string message, AlertDialogButton button1text, Action button1action, AlertDialogButton button2text, Action button2action, AlertDialogButton button3text, Action button3action)
        {
            using (var dialog = new AlertDialog.Builder(activity))
            {
                var alert = dialog.Create();
                alert.SetTitle(title);
                alert.SetMessage(message);
                var enumToString = new Dictionary<AlertDialogButton, string>
                {
                    { AlertDialogButton.Ok, "OK" },
                    { AlertDialogButton.Cancel, "CANCEL" },
                    { AlertDialogButton.Yes, "YES" },
                    { AlertDialogButton.No, "NO" },
                    { AlertDialogButton.Apply, "APPLY" },
                    { AlertDialogButton.Save, "SAVE" },
                    { AlertDialogButton.Exit, "EXIT" },
                };
                if (enumToString.TryGetValue(button1text, out string button1textstring) && enumToString.TryGetValue(button2text, out string button2textstring) && enumToString.TryGetValue(button3text, out string button3textstring))
                {
                    alert.SetButton(button1textstring, (c, ev) => { button1action?.Invoke(); });
                    alert.SetButton2(button2textstring, (c, ev) => { button2action?.Invoke(); });
                    alert.SetButton3(button3textstring, (c, ev) => { button3action?.Invoke(); });
                    alert.Show();
                }
                else
                {
                    throw new InvalidOperationException($"{button1text}, {button2text} or {button3text} could not be resolved to a string through the given dictionary when creating the Alert Dialog");
                }
            }
        }

        #endregion

        public static void openDiscordServer(Context context) {
            var browserIntent = new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://discord.gg/zjJtMxu"));
            context.StartActivity(browserIntent);
        }

        public static void closeApplication()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}
