using Android.Views;

namespace RevisR
{
    class IDisableBackOnKeyListener : Java.Lang.Object, View.IOnKeyListener
    {
        public IDisableBackOnKeyListener(View view)
        {
            this.view = view;
        }

        private readonly View view;

        bool View.IOnKeyListener.OnKey(View v, Keycode k, KeyEvent e)
        {
            if (e.Action == KeyEventActions.Down && k.Equals(Keycode.Back))
            {
                return true;
            }
            return false;
        }
    }
}