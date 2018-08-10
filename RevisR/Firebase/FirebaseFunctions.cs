using Android.Content;
using Android.OS;
using Firebase.Messaging;
using Firebase.Iid;
using Android.Util;
using System;
using Android.Gms.Common;
using Android.App;

namespace RevisR.Firebase
{
    public static class FirebaseFunctions
    {
        private const string TAG = nameof(FirebaseFunctions);

        public static Tuple<bool, string> IsGooglePlayServicesInstalled(Activity activity)
        {
            var resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(activity);
            return resultCode != ConnectionResult.Success ? new Tuple<bool, string>(false, GoogleApiAvailability.Instance.IsUserResolvableError(resultCode) ? GoogleApiAvailability.Instance.GetErrorString(resultCode) : "This device is unsupported.") : new Tuple<bool, string>(true, "Google Play Services are available on this device.");
        }

        public static void CreateNotificationChannel(Activity activity)
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
            {
                // Notification channels are new in API 26 (and not a part of the
                // support library). There is no need to create a notification
                // channel on older versions of Android.
                return;
            }

            var channel = new NotificationChannel(MainActivity.CHANNEL_ID,
                                                  "FCM Notifications",
                                                  NotificationImportance.Default)
            {
                Description = "Firebase Cloud Messages appear in this channel"
            };

            var notificationManager = (NotificationManager)activity.GetSystemService(Context.NotificationService);
            notificationManager.CreateNotificationChannel(channel);
        }

        public static void subscribeToTopic(string topic)
        {
            FirebaseMessaging.Instance.SubscribeToTopic(topic);
#if DEBUG
            Log.Debug(TAG, "Subscribed to remote notifications");
#endif
        }
    }
}