using Android.App;
using Android.OS;
using Android.Views;

namespace RevisR.Fragments.English.Language
{
    public class EnglishLangPaper1bFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.english_paper1b, container, false);
        }
    }
}