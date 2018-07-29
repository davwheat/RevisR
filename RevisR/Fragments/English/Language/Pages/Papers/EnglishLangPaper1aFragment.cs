using Android.App;
using Android.OS;
using Android.Views;

namespace RevisR.Fragments.English.Language.Pages.Papers
{
    public class EnglishLangPaper1aFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.english_paper1a, container, false);
        }
    }
}