using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace RevisR
{
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
                // Must Know
                view.FindViewById(Resource.Id.engLitShowAlliteration),
                view.FindViewById(Resource.Id.engLitShowBias),
                view.FindViewById(Resource.Id.engLitShowConnotations),
                view.FindViewById(Resource.Id.engLitShowDialogue),
                view.FindViewById(Resource.Id.engLitShowDirective),
                view.FindViewById(Resource.Id.engLitShowElipsis),
                view.FindViewById(Resource.Id.engLitShowEmotiveLanguage),
                view.FindViewById(Resource.Id.engLitShowFacts),
                view.FindViewById(Resource.Id.engLitShowFirstPerson),
                view.FindViewById(Resource.Id.engLitShowHumour),
                view.FindViewById(Resource.Id.engLitShowHyperbole),
                view.FindViewById(Resource.Id.engLitShowImagery),
                view.FindViewById(Resource.Id.engLitShowMetaphor),
                view.FindViewById(Resource.Id.engLitShowPersonification),
                view.FindViewById(Resource.Id.engLitShowRepitition),
                view.FindViewById(Resource.Id.engLitShowRhetoricalQuestions),
                view.FindViewById(Resource.Id.engLitShowSimile),
                view.FindViewById(Resource.Id.engLitShowStatistics),
                view.FindViewById(Resource.Id.engLitShowThirdPerson),
                view.FindViewById(Resource.Id.engLitShowTone),
                view.FindViewById(Resource.Id.engLitShowTriplets),
                
                // Others
                view.FindViewById(Resource.Id.engLitShowAllegory),
                view.FindViewById(Resource.Id.engLitShowAnecdote),
                view.FindViewById(Resource.Id.engLitShowAssonance),
                view.FindViewById(Resource.Id.engLitShowCaesura),
                view.FindViewById(Resource.Id.engLitShowCliche),
                view.FindViewById(Resource.Id.engLitShowConsonance),
                view.FindViewById(Resource.Id.engLitShowEndStopping),
                view.FindViewById(Resource.Id.engLitShowExtendedMetaphor),
                view.FindViewById(Resource.Id.engLitShowJuxtaposition),
                view.FindViewById(Resource.Id.engLitShowMotif),
                view.FindViewById(Resource.Id.engLitShowOnomatopoeia),
                view.FindViewById(Resource.Id.engLitShowOxymoron),
                view.FindViewById(Resource.Id.engLitShowPatheticFallacy),
                view.FindViewById(Resource.Id.engLitShowProtagonist),
                view.FindViewById(Resource.Id.engLitShowSecondPerson),
                view.FindViewById(Resource.Id.engLitShowSensoryDetailImagery),
                view.FindViewById(Resource.Id.engLitShowSibilance),
                view.FindViewById(Resource.Id.engLitShowSuperlative),
                view.FindViewById(Resource.Id.engLitShowSymbolism),
                view.FindViewById(Resource.Id.engLitShowTense)
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

                var values = new[]
                {
                    // Must Know
                    new KeyValuePair<string, string>("Alliteration", "A series of words in a row which have the same first consonant sound. For example 'an ant ate an apple'."),
                    new KeyValuePair<string, string>("Bias", "Inclination or prejudice for or against one person or group, especially in a way considered to be unfair."),
                    new KeyValuePair<string, string>("Connotations", "Implied or suggested meanings of words or phrases."),
                    new KeyValuePair<string, string>("Dialogue", "Speech."),
                    new KeyValuePair<string, string>("Directive", "Using 'you', 'we' or 'us'."),
                    new KeyValuePair<string, string>("Elipsis", "Using 3 full-stops/dots as punctuation to express emotion or that something has been omitted from the writing"),
                    new KeyValuePair<string, string>("Emotive Language", "Language which creates an emotion in the reader."),
                    new KeyValuePair<string, string>("Facts", "Information that can be proven."),
                    new KeyValuePair<string, string>("First Person", "Using 'I' to tell the story."),
                    new KeyValuePair<string, string>("Humour", "Provoking laughter and providing amusement."),
                    new KeyValuePair<string, string>("Hyperbole", "Use of exaggerated terms for emphasis."),
                    new KeyValuePair<string, string>("Imagery", "Creating a picture inside the reader's head."),
                    new KeyValuePair<string, string>("Metaphor", "A comparison as if something is something else."),
                    new KeyValuePair<string, string>("Opinion", "Information that you can't prove."),
                    new KeyValuePair<string, string>("Personification", "Giving an inanimate object, animal, or natural phenomena human qualities."),
                    new KeyValuePair<string, string>("Repitition", "When words/phrases are used more than once in a piece of writing, usually for effect. (e.g. 'Exposure' by Wilfred Owen: 'But nothing happens')"),
                    new KeyValuePair<string, string>("Rhetorical Questions", "Asking a question as a way of asserting something. Asking a question without wanting an answer or having a hidden/implicit answer in it."),
                    new KeyValuePair<string, string>("Simile", "Comparison between two things using either 'like' or 'as'."),
                    new KeyValuePair<string, string>("Statistics", "Facts and figures. (e.g. 2/3 of people think that...)"),
                    new KeyValuePair<string, string>("Third Person", "Using 'he', 'she' and 'they' to tell the story."),
                    new KeyValuePair<string, string>("Tone", "The way a piece sounds to the reader. (e.g. sarcastic)"),
                    new KeyValuePair<string, string>("Triplets", "The repetition of three ideas, words or phrases close together."),
                    
                    // Others
                    new KeyValuePair<string, string>("Allegory", "An extended metaphor in which a symbolic story is told. Used most notably in 'The Lion, the Witch, and the Wardrobe' by C.S. Lewis; and 'The Lord of the Flies' by Willian Golding."),
                    new KeyValuePair<string, string>("Anecdote", "A short story using examples to support ideas, bring cheer, reminisce or to caution. For example: 'The Boy Who Cried Wolf'."),
                    new KeyValuePair<string, string>("Assonance", "The repetition of vowel sounds."),
                    new KeyValuePair<string, string>("Caesura", "A break in the middle of a line of poem which uses any form of punctuation."),
                    new KeyValuePair<string, string>("Cliché", "An overused phrase or theme. For example: 'in the nick of time' or 'fit as a fiddle' or 'frightened to death'."),
                    new KeyValuePair<string, string>("Consonance", "The repetition of consonant sounds, most commonly within a short passage of verse."),
                    new KeyValuePair<string, string>("End Stopping", "Punctuation at the end of a line of poetry."),
                    new KeyValuePair<string, string>("Enjambment", "Incomplete sentences at the end of lines in poetry."),
                    new KeyValuePair<string, string>("Extended Metaphor", "A metaphor that continues into the sentence that follows or throughout the text."),
                    new KeyValuePair<string, string>("Juxtaposition", "Placing contrasting ideas close together in a text."),
                    new KeyValuePair<string, string>("Motif", "A recurring set of words/phrases or imagery for effect."),
                    new KeyValuePair<string, string>("Onomatopoeia", "Words that sound like their meaning. (e.g. bang, splash, pew, kaboom, crash, etc.)"),
                    new KeyValuePair<string, string>("Oxymoron", "Using two terms together, that normally contradict each other. (e.g. pretty ugly)"),
                    new KeyValuePair<string, string>("Pathetic Fallacy", "Ascribing human conduct and feelings to nature or, commonly, weather."),
                    new KeyValuePair<string, string>("Protagonist", "The main character that propels the action forward."),
                    new KeyValuePair<string, string>("Second Person", "Using 'you' to tell the story."),
                    new KeyValuePair<string, string>("Sensory Detail Imagery", "Using senses (sight, smell, touch, sound and taste) for effect."),
                    new KeyValuePair<string, string>("Sibilance", "Repetition of letter 's'. It is a form of alliteration."),
                    new KeyValuePair<string, string>("Superlative", "Declaring that something is the best in its class (e.g. the ugliest, the most precious, the worst)"),
                    new KeyValuePair<string, string>("Symbolism", "The use of symbols to represent ideas or qualities."),
                    new KeyValuePair<string, string>("Tense", "Whether the writing is set in the past, present or future."),
                };

                var dict = new Dictionary<string, string>(values);

                var notDefaultValue = dict.TryGetValue(buttonText, out string msg);
                if (notDefaultValue)
                {
                    ad.SetMessage(msg);

                    ad.SetCancelable(true);
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