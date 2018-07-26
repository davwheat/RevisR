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
                view.FindViewById(Resource.Id.engLitShowAllegory),
                view.FindViewById(Resource.Id.engLitShowAlliteration),
                view.FindViewById(Resource.Id.engLitShowAnecdote),
                view.FindViewById(Resource.Id.engLitShowAssonance),
                view.FindViewById(Resource.Id.engLitShowBias),
                view.FindViewById(Resource.Id.engLitShowCaesura),
                view.FindViewById(Resource.Id.engLitShowCliche),
                view.FindViewById(Resource.Id.engLitShowConnotations),
                view.FindViewById(Resource.Id.engLitShowConsonance),
                view.FindViewById(Resource.Id.engLitShowDialogue),
                view.FindViewById(Resource.Id.engLitShowDirective),
                view.FindViewById(Resource.Id.engLitShowElipsis),
                view.FindViewById(Resource.Id.engLitShowEmotiveLanguage),
                view.FindViewById(Resource.Id.engLitShowEndStopping),
                view.FindViewById(Resource.Id.engLitShowExtendedMetaphor),
                view.FindViewById(Resource.Id.engLitShowFacts),
                view.FindViewById(Resource.Id.engLitShowFirstPerson),
                view.FindViewById(Resource.Id.engLitShowHumour),
                view.FindViewById(Resource.Id.engLitShowHyperbole),
                view.FindViewById(Resource.Id.engLitShowImagery),
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

                    case "Assonance":
                        ad.SetMessage("The repetition of vowel sounds.");
                        break;

                    case "Alliteration":
                        ad.SetMessage("A series of words in a row which have the same first consonant sound. For example 'an " +
                            "ant ate an apple'.");
                        break;

                    case "Anecdote":
                        ad.SetMessage("A short story using examples to support ideas, bring cheer, reminisce or to caution. For " +
                            "example: 'The Boy Who Cried Wolf'.");
                        break;

                    case "Allegory":
                        ad.SetMessage("An extended metaphor in which a symbolic story is told. Used most notably in 'The Lion, " +
                            "the Witch, and the Wardrobe' by C.S. Lewis; and 'The Lord of the Flies' by Willian Golding.");
                        break;

                    case "Bias":
                        ad.SetMessage("Inclination or prejudice for or against one person or group, especially in a way considered " +
                            "to be unfair.");
                        break;

                    case "Caesura":
                        ad.SetMessage("A break in the middle of a line of poem which uses any form of punctuation.");
                        break;

                    case "Cliché":
                        ad.SetMessage("An overused phrase or theme. For example: 'in the nick of time' or 'fit as a fiddle' or " +
                            "'frightened to death'.");
                        break;

                    case "Connotations":
                        ad.SetMessage("Implied or suggested meanings of words or phrases.");
                        break;

                    case "Consonance":
                        ad.SetMessage("The repetition of consonant sounds, most commonly within a short passage of verse.");
                        break;

                    case "Dialogue":
                        ad.SetMessage("Speech.");
                        break;

                    case "Directive":
                        ad.SetMessage("Using 'you', 'we' or 'us'.");
                        break;

                    case "Elipsis":
                        ad.SetMessage("Using 3 full-stops/dots as punctuation to express emotion or that something has been " +
                            "omitted from the writing");
                        break;

                    case "End Stopping":
                        ad.SetMessage("Punctuation at the end of a line of poetry.");
                        break;

                    case "Enjambment":
                        ad.SetMessage("Incomplete sentences at the end of lines in poetry.");
                        break;

                    case "Emotive Language":
                        ad.SetMessage("Language which creates an emotion in the reader.");
                        break;

                    case "Extended Metaphor":
                        ad.SetMessage("A metaphor that continues into the sentence that follows or throughout the text.");
                        break;

                    case "Text":
                        ad.SetMessage("Message");
                        break;

                    case "Facts":
                        ad.SetMessage("Information that can be proven.");
                        break;

                    case "First Person":
                        ad.SetMessage("Using 'I' to tell the story.");
                        break;

                    case "Humour":
                        ad.SetMessage("Provoking laughter and providing amusement.");
                        break;

                    case "Hyperbole":
                        ad.SetMessage("Use of exaggerated terms for emphasis.");
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