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
    public class AlertDialogButtonEnumValueNotResolvableToButtonTextStringException : Exception
    {
        public AlertDialogButtonEnumValueNotResolvableToButtonTextStringException() { }
        public AlertDialogButtonEnumValueNotResolvableToButtonTextStringException(string message) : base(message) { }
        public AlertDialogButtonEnumValueNotResolvableToButtonTextStringException(string message, Exception inner) : base(message, inner) { }
        protected AlertDialogButtonEnumValueNotResolvableToButtonTextStringException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}