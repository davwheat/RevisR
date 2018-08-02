using Android.App;
using Android.OS;
using Android.Views;

namespace RevisR.Fragments.English.Language.Pages.Papers
{
    public class EnglishLangPaper1bFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.english_paper1b, container, false);
        }
    }
}