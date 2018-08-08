using Android.Content;
using Android.OS;
using Plugin.FirebasePushNotification;

namespace RevisR
{
    public static class Firebase
    {
        public static void InitialiseFirebase(Context context)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                //Change for your default notification channel id here
                FirebasePushNotificationManager.DefaultNotificationChannelId = "general";

                //Change for your default notification channel name here
                FirebasePushNotificationManager.DefaultNotificationChannelName = "General";
            }

            //If debug you should reset the token each time.
#if DEBUG
            FirebasePushNotificationManager.Initialize(context, true);
#else
            FirebasePushNotificationManager.Initialize(context,false);
#endif

            //Handle notification when app is closed here
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {

            };
        }
    }
}