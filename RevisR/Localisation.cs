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

namespace RevisR
{
    public static class Localisation
    {
        public static string snackbarComingSoon => "Feature coming soon";
        public static string snackbarError => "An error ocurred";

        public static string feedbackEmail => "davidwheatley03@gmail.com";
        public static string feedbackSubject => "RevisR Feedback";
        public static string feedbackBody => "Please enter the feedback you would like to give...";
    }
}