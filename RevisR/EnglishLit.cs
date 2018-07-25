using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace RevisR
{
    public class EnglishLitFragment : Fragment
    {
        private View view;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.english_lit, container, false);

            ((TextView)view.FindViewById(Resource.Id.engLitTechniquesButton)).Click += openEnglishTechniques;

            return view;
        }

        public void openEnglishTechniques(object sender, EventArgs e)
        {
            Fragment fragment = new EnglishLitTechniquesFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }
    }

    public class EnglishLitTechniquesFragment : Fragment
    {
        private View view;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.english_lit_techniques, container, false);

            var buttons = new List<View>
            {
                view.FindViewById(Resource.Id.engLitShowAlliteration),
                view.FindViewById(Resource.Id.engLitShowAssonance),
                view.FindViewById(Resource.Id.engLitShowAllegory),
                view.FindViewById(Resource.Id.engLitShowAnecdote),
                view.FindViewById(Resource.Id.engLitShowBias),
                view.FindViewById(Resource.Id.engLitShowCliche),
            };

            foreach (var b in buttons)
            {
                b.Click += (object sender, EventArgs e) =>
                {
                    defineTechnique(b.Id);
                };
            }

            return view;
        }

        public void defineTechnique(int id)
        {
            var buttonText = ((TextView)view.FindViewById(id)).Text;
            using (var builder = new AlertDialog.Builder(Context))
            {
                var ad = builder.Create();

                switch (buttonText)
                {
                    default:
                        ad = null;
                        break;

                    case "Alliteration":
                        ad.SetMessage("A series of words in a row which have the same first consonant sound. For example 'an ant ate an apple'.");
                        break;

                    case "Assonance":
                        ad.SetMessage("The repetition of vowel sounds.");
                        break;

                    case "Allegory":
                        ad.SetMessage("An extended metaphor in which a symbolic story is told. Used most notably in 'The Lion, the Witch, and the Wardrobe' by C.S. Lewis; and 'The Lord of the Flies' by Willian Golding.");
                        break;

                    case "Anecdote":
                        ad.SetMessage("A short story using examples to support ideas, bring cheer, reminisce or to caution. For example: 'The Boy Who Cried Wolf'.");
                        break;

                    case "Bias":
                        ad.SetMessage("Inclination or prejudice for or against one person or group, especially in a way considered to be unfair.");
                        break;

                    case "Cliché":
                        ad.SetMessage("An overused phrase or theme. For example: 'in the nick of time' or 'fit as a fiddle' or 'frightened to death'.");
                        break;

                    case "Text":
                        ad.SetMessage("Message");
                        break;
                }

                if (ad != null)
                {
                    ad.SetCancelable(false);
                    ad.SetTitle(buttonText);

                    ad.SetButton("Close", (s, ev) => { });

                    ad.Show();
                }
                else
                {
                    Toast.MakeText(Context, "An error occurred.", ToastLength.Long);
                }
            }
        }
    }
}