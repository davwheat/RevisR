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

namespace RevisR.Fragments.Computing.Hardware.Pages
{
    class ComputingCpuFragment : Fragment
    {
        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.english_lit_punctuation, container, false);

            // Set the punctuationList variable for use in other functions
            var hardwareExpandableList = (ExpandableListView)view.FindViewById(Resource.Id.computingHardwareCpuExpandableList);

            var headings = new List<string>
            {
                "What is a CPU?",
                "Main Components",
                "Input, Process, Output Model",
                "IPO Model Example",
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

            var content = new List<List<string>>
            {
                // \n is a new line
                new List<string> { "A central processing unit (CPU) is the electronic circuitry within a computer that carries out the instructions of a computer program by performing the basic arithmetic, logical, control and input/output (I/O) operations specified by the instructions. The computer industry has used the term \"central processing unit\" at least since the early 1960s. Traditionally, the term \"CPU\" refers to a processor, more specifically to its processing unit and control unit (CU), distinguishing these core elements of a computer from external components such as main memory and I/O circuitry." },
                new List<string> { "There are four main components of the CPU. There is the:\n  - Arithmatic Logic Unit\n - Control Unit\n - Clock\n - Bus\n\n" },
                new List<string> { "This example represents a supermarket checkout computer system." },
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

            fillListView(hardwareExpandableList, headings, content);

            return view;
        }

        public void fillListView(ExpandableListView elv, List<string> headings, List<List<string>> textContent)
        {
            // Create dictionary with expandablelistview data
            var data = new Dictionary<string, List<string>>();
            // Add the data to the dictionary
            foreach (var i in headings) { data.Add(i, textContent[headings.IndexOf(i)]); }

            // Create ELV adapter using homebrewed class
            IExpandableListAdapter adapter = new CustomExpandableListAdaptor(Context, headings, data);
            // Set the adapter
            elv.SetAdapter(adapter);
        }
    }
}