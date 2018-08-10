using System;
using Android.App;
using Firebase.Iid;
using Android.Util;

namespace RevisR.Firebase
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class MyFirebaseIIDService : FirebaseInstanceIdService
    {
        const string TAG = nameof(MyFirebaseIIDService);
        public override void OnTokenRefresh()
        {
            var refreshedToken = FirebaseInstanceId.Instance.Token;
#if DEBUG
            Log.Debug(TAG, "Refreshed token: " + refreshedToken);
#endif
            SendRegistrationToServer(refreshedToken);
        }

        static void SendRegistrationToServer(string token)
        {
            // This is NOT NEEDED (at the moment...)
        }
    }
}