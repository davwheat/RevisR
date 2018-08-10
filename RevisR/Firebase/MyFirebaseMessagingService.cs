﻿using Android.App;
using Android.Content;
using Android.Support.V4.App;
using Android.Util;
using Firebase.Messaging;
using System.Collections.Generic;

namespace RevisR.Firebase
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        private const string TAG = nameof(MyFirebaseMessagingService);

        public override void OnMessageReceived(RemoteMessage message)
        {
            var body = message.GetNotification().Body;
#if DEBUG
            Log.Debug(TAG, "From: " + message.From);
            Log.Debug(TAG, "Notification Message Body: " + body);
#endif
            SendNotification(body, message.Data);
        }

        void SendNotification(string messageBody, IDictionary<string, string> data)
        {
            var intent = new Intent(this, typeof(MainActivity));
            intent.AddFlags(ActivityFlags.ClearTop);
            foreach (var key in data.Keys)
            {
                intent.PutExtra(key, data[key]);
            }

            var pendingIntent = PendingIntent.GetActivity(this,
                                                          MainActivity.NOTIFICATION_ID,
                                                          intent,
                                                          PendingIntentFlags.OneShot);
            using (var builder = new NotificationCompat.Builder(this, MainActivity.CHANNEL_ID)
            )
            {
                var notificationBuilder = builder.SetSmallIcon(Resource.Drawable.notification)
                                          .SetContentTitle("FCM Message")
                                          .SetContentText(messageBody)
                                          .SetAutoCancel(true)
                                          .SetContentIntent(pendingIntent);

                var notificationManager = NotificationManagerCompat.From(this);
                notificationManager.Notify(MainActivity.NOTIFICATION_ID, notificationBuilder.Build());
            }
        }
    }
}