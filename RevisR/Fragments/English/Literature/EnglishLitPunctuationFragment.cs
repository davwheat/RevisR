using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace RevisR
{
    public class EnglishLitPunctuationFragment : Fragment
    {
        private View view;
        private ExpandableListView punctuationList;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.english_lit_punctuation, container, false);

            // Set the punctuationList variable for use in other functions
            punctuationList = (ExpandableListView)view.FindViewById(Resource.Id.engLitPunctuationExpandableList);

            fillListView();

            return view;
        }

        public void fillListView()
        {
            // Types of punctuation
            var punctuation = new List<string>
            {
                "Apostrophe",
                "Brackets",
                "Colon",
                "Comma",
                "Dash",
                "Ellipsis",
                "Ellipsis (in quotations)",
                "Exclamation Mark",
                "Full Stop",
                "Hyphen",
                "Semicolon",
                "Speech Marks/Inverted Commas",
                "Question Mark",
            };

            // Usage of the punctuation
            var explanations = new List<List<string>>
            {
                // \n is a new line
                new List<string> { "You can use apostrophes to show possession.\nFor example: \"Malcom's cat was extremely friendly.\",\nor \"We took a day trip to Gibson's house.\"\n\nYou can also use them to show missing letter(s).\nFor Example: \"It doesn't matter.\",\nor \"I'm sorry.\"\n\nMore rarely, they can be used in some single letter plurals.\nFor Example: \"Don't forget your p's and q's.\",\nor \"Jason spells cook with two k's!\"" },
                new List<string> { "There are two main types of brackets.\n\nRound brackets are mainly used to separate off information that isn't essential to the meaning of the rest of the sentence.\nFor example: \"He asked Sarah (his great-aunt) for a loan.\"\n\nSquare brackets are mainly used to enclose words added by someone other than the original writer or speaker, typically in order to clarify the situation.\nFor example: \"The witness said: 'Gary [Thompson] was not usually late for work.'\"" },
                new List<string> { "You can use a colon between two main clauses where the second clause explains or follows from the first.\nFor example: \"We have a motto: live life to the full.\"\n\nYou can also use them to introduce a list.\nFor example: \"The cost of the room includes the following: breakfast, dinner, and Wi-Fi.\".\n\nMore rarely, they can be used before a quotation, and sometimes before direct speech: \"The headline read: 'Local Woman Saves Geese'.\"" },
                new List<string> { "A comma marks a slight break between different parts of a sentence. There are four common occasions on which commas are necessary; see the 'Comma Use' page for more info.\n\nUsing commas in lists (e.g. The flag was red, white, and blue.)\nUsing commas in direct speech (e.g. 'That's not fair,' she said.)\nUsing commas to separate clauses (e.g. As we had already arrived, we were reluctant to wait.)\nUsing commas to mark off parts of a sentence (Her best friend, Eliza, sang for a living.) " },
                new List<string> { "There are two main occasions on which a dash can be used, usually in informal writing.\n\nYou can use them to mark off information that is not essential to an understanding of the rest of the sentence.\nFor example: \"Many birds — do you like birds ? — can be seen outside the window.\"\n\nYou can also use them to show other kinds of break in a sentence where a comma, semicolon, or colon would be traditionally used.\nFor example: \"Tommy can't wait for Christmas — he's very excited.\"" },
                new List<string> { "In informal writing, an ellipsis can be used to represent a trailing off of thought.\nFor example: \"If only she had ... Oh, it doesn't matter now.\"\n\nAn ellipsis can also indicate hesitation, though in this case the punctuation is more accurately described as suspension points.\nFor example: \"I wasn't really ... well, what I mean ... see, the thing is ... I didn't mean it.\"\n\nJust like the exclamation mark, the ellipsis is at risk of overuse." },
                new List<string> { "When a quotation is included within a larger sentence, do not use ellipsis points at the beginning or end of the quoted material, even if the beginning or end of the original sentence has been omitted.\n\nCorrect: When Thoreau argues that by simplifying one's life, \"the laws of the universe will appear less complex,\" he introduces an idea explored at length in his subsequent writings.\n\nIncorrect: When Thoreau argues that by simplifying one's life, \"...the laws of the universe will appear less complex,...\" he introduces an idea explored at length in his subsequent writings." },
                new List<string> { "The main uses of the exclamation mark most commonly used in informal writing.\nYou can use them to show an exclamation.\nFor example: \"Ow! That hurts!\"\n\nYou can also use it for direct speech that represents something shouted or spoken very loudly.\nFor example: \"Run as fast as you can!' he shouted.\n\nYou can also use it for something that amuses the writer.\nFor example: \"They thought I was dressed as a smuggler!\"\n\nFinally, you can use an exclamation mark can also be used in brackets after a statement to show that the writer finds it funny or ironic.\nFor example: \"He thought it would be amusing to throw a plastic mouse at me(!)\"" },
                new List<string> { "Full stops are used for many different purposes.\n\n You can use them to mark the end of a sentence that is a complete statement.\nFor example: \"All their meals arrived at the same time.\"\n\nOr to mark the end of a group of words that don't form a conventional sentence, so as to emphasize a statement.\nFor example: \"It's never acceptable to arrive late. Not under any circumstances.\"\n\nAlso in some abbreviations, for example etc., Jan., or a.m.\nFor example: \"Please return the form by Monday 8 Dec. at the latest.\",\nor \"The shop has groceries, toiletries, etc. and is open all day.\"\n\nThey are also used in website and email addresses.\nFor example: \"www.google.co.uk\"" },
                new List<string> { "Hyphens are used to link words and parts of words. There are three main cases where you should use them.\n\nYou should use them in compound words, like mother-in-law.\n\nYou also use them to join prefixes to other words.\nFor example: \"The novel is clearly intended to be a post-Marxist work.\"\n\nThey can be used to show word breaks.\nFor example: \"He collects eighteenth- and nineteenth-century vases.\"" },
                new List<string> { "The semicolon is most commonly used to mark a break that is stronger than a comma but not as final as a full stop. It's used between two main clauses that balance each other and are too closely linked to be made into separate sentences.\nFor example: \"The film was a critical success; its lead actors were particularly praised.\"" },
                new List<string> { "In British English, we tend to use single inverted commas (''), however double quotes (\"\") are correct too.\nThese are used to separate quoted words from the rest of the text allowing the reader to follow what is happening.\nFor example: 'It's true, you know.',\nor \"It's true, you know.\"" },
                new List<string> { "A question mark is used to indicate the end of a question.\nFor example: \"What time are you going to the fair?\"\n\nA question mark can also be used in brackets to show that the writer is unconvinced by a statement.\nFor example: \"The bus timetable purports to be accurate(?).\"" },
            };

            // Create dictionary with expandablelistview data
            var data = new Dictionary<string, List<string>>();
            // Add the data to the dictionary
            foreach (var i in punctuation) { data.Add(i, explanations[punctuation.IndexOf(i)]); }

            // Create ELV adapter using homebrewed class
            IExpandableListAdapter adapter = new CustomExpandableListAdaptor(Context, punctuation, data);
            // Set the adapter
            punctuationList.SetAdapter(adapter);
        }
    }
}