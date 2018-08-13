using System;
using Android.App;
using Android.Content;
using Android.Gms.Ads;

namespace RevisR.AdMob
{
    public class AdMobFunctions
    {
        public static bool AdsEnabled; // Will be changed when Ads are enabled/disabled

        public static void Initialise(Activity activity) // Called when app started and on ad enable/disable state toggle
        {
            if (Common.getSettingBool("areAdsEnabled", false)) // If ads are currently enabled/disabled (default is false)...
            {
                AdsEnabled = true; // then set the bool to valid state
            }
            else
            {
                var lastAdDialogTime = Common.getSettingLong("lastAdDialogTime"); // otherwise get when the last ad enable prompt was shown
                if (lastAdDialogTime == -1) // User has never been previously asked or error occurred
                    lastAdDialogTime = DateTime.UtcNow.AddDays(-7).Ticks; // So prompt them now
                if ((DateTime.UtcNow - new DateTime(lastAdDialogTime)).Days >= 7) // and if it was 7+ days ago...
                {
                    AdDialogPrompt(activity); // Show another prompt to enabled ads to support the developer
                }
            }
        }

        private static void AdDialogPrompt(Activity activity)
        {
            Common.showAlertDialog( // Show ad enable prompt
                activity,
                "Support the developer?",
                "Do you want to help support the developer with ads? These will always be optional and non-intrusive.\n\nThis is my only source of revenue, so I'd ❤️ you if you'd enable these :3",
                Common.AlertDialogButton.Yes,
                () => { // If user chooses yes
                    Common.saveSetting("areAdsEnabled", true); // Save the decision
                    Common.saveSetting("lastAdDialogTime", DateTime.UtcNow.Ticks); // Set the last ad dialog time
                    Initialise(activity); // Reinitialise the ad system
                },
                Common.AlertDialogButton.No,
                () => { // but if they say no, show a snackbar informing them about the recognition of their decision and telling them they WILL be renotified
                    Common.showSnackbar(
                        activity
                            .Window
                            .DecorView
                            .FindViewById(Android.Resource.Id.Content),
                        "Aww... We'll ask you again in 7 days."
                    );
                });
        }

        public static AdView getBannerAd(Context context, string adUnitId = @"ca-app-pub-2701335557132384/2164647426")
        {
            if (AdsEnabled) // Checks if ads were enabled by the user
            {
                var ad = new AdView(context)
                {
                    AdSize = AdSize.SmartBanner,
                    AdUnitId = adUnitId
                };

                using (var requestbuilder = new AdRequest.Builder())
                {
                    ad.LoadAd(requestbuilder.AddTestDevice("B72AFAECF9C131F3912288D401FF5240").Build());
                    return ad;
                }
            }
            else
            {
                return null;
            }
        }
    }
}