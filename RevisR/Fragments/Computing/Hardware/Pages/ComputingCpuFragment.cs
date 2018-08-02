using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace RevisR.Fragments.Computing.Hardware.Pages
{
    class ComputingCpuFragment : Fragment
    {
        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.computing_hardware_cpu, container, false);

            // Set the punctuationList variable for use in other functions
            var hardwareExpandableList = (ExpandableListView)view.FindViewById(Resource.Id.computingHardwareCpuExpandableList);

            var headings = new List<string>
            {
                "What is a CPU?",
                "Main Components",
                "Input, Process, Output Model",
                "IPO Model Example",
                "List of Input Devices",
                "List of Storage Devices",
                "List of Output Devices",
                "Introduction to Processing",
                "Arithmatic & Logic Unit (ALU)",
                "Processing Power (Clocks)",
                "Memory (RAM and ROM)",
                "Fetch, Decode, Execute Cycle",
            };

            var content = new List<List<string>>
            {
                // \n is a new line
                new List<string> { "A central processing unit (CPU) is the electronic circuitry within a computer that carries out the instructions of a computer program by performing the basic arithmetic, logical, control and input/output (I/O) operations specified by the instructions. The computer industry has used the term \"central processing unit\" at least since the early 1960s. Traditionally, the term \"CPU\" refers to a processor, more specifically to its processing unit and control unit (CU), distinguishing these core elements of a computer from external components such as main memory and I/O circuitry." },
                new List<string> { "There are four main components of the CPU. There is the:\n  - Arithmatic & Logic Unit (ALU)\n - Control Unit\n - Clock\n - Bus" },
                new List<string> { "Most modern computer systems can be described using the input, process, output model.\nThe model works like a flowchart, that demonstrates how data is input into the system, which is processed to create stored data or an output.\n\nAn input device sends a signal to the processor that processes the data and either sends data into storage or to an output device." },
                new List<string> { "This example represents a supermarket checkout computer system.\n\nThe cashier scans the item(s) using the barcode scanner (an input). After each item the speaker bleeps (a sound output) and the item appears on screen (a display/visual output).\n\nThe cashier begins the transaction using the touchscreen (an input) and the customer pays with cash, or using card via chip and pin machine or an NFC tag reader (both inputs).\n\nThe transaction in processed then stored on a central system.\n\nFinally, the receipt prints (output) and the cashier is ready for the next customer." },
                new List<string> { "Input devices (non-exhaustive):\n - Mouse\n - Keyboard\n - Graphics Tablet\n - Touchscreen\n - Webcam\n - Scanner\n - Microphone" },
                new List<string> { "Storage devices (non-exhaustive):\n - RAM\n - ROM\n - USB Flash Drive\n - Hard Disk Drive\n - Solid State Drive\n - Flash Memory\n - Network Attached Storage/Network Drive" },
                new List<string> { "Output devices (non-exhaustive):\n - Speakers/Headphones\n - Projector\n - Monitor\n - Vibration\n - Printer\n - Motor\n - LED" },
                new List<string> { "The CPU (Central Processing Unit) is the square chip most likely to be produced by Intel or AMD (in PCs) or Qualcomm for phones and tablets.\n\nIt's job transfers data between input, output and storage devices.\n\nAs it is constantly active running many tasks while the computer is on, it requires its own fan, heatsink and application of thermal paste to prevent it overheating." },
                new List<string> { "The ALU (Arithmetic & Logic Unit) contains electronic circuits that perform simple binary (on or off) and logical operations (AND, IF, NOT, OR, XOR, etc.)." },
                new List<string> { "Every processor has a 'clock', but it's not the time-telling kind.\n\nA processor clock keeps the electronic circuits synchronised by sending small electrical pulses (like the beat an orchestra plays to to stay in sync).\n\nThe electrical pulses are measured in MHz (megahertz) or (more commonly) GHz (gigahertz). A typical gaming computer normally has a clock speed of 3.3 Ghz to 3.69 GHz (according to the Steam Hardware & Software Survey). The faster the clock speed, the more instructions the computer can process per second. 1 GHz = 1 billion pulses per second, 2 GHz = 2 bn pulses, etc.\n\nMost CPUs have multiple cores. Each core can execute instuctions simultaneously therefore the more cores, the more tasks the CPU can carry out. According to the same survey, the average number of cores is 4 (called quad-core). There is also dual-core (2), hex-core (6), octa-core (8), and (on the most high end chips) 12 or 16-core CPUs.\n\nSome CPUs also have a technology called Simultaneous Multithreading (SMT), sometimes referred to as hyperthreading on Intel CPUs. This allows a core to act as two meaning each core runs a separate thread. The only difference is that one thread MUST wait for the other to finish, whereas separate cores do not. If one thread was calculating 1+1, but the other was calculating (2^198 / 65^189) * 1789 - 18571^14 I'm sure you can guess which would finish first. Despite this the first thread would have to wait for the second to finish before the processor could output anything." },
                new List<string> { "There are two main types of memory: RAM & ROM. Both are solid state meaning there are no moving parts.\n\nRAM (Random Access Memory) is used to store programs and data being processed by the CPU that the user has accessed. RAM requires a constant power supply as it is volatile. When it loses power all information stored on it is lost. Data on RAM can be added, edited and deleted by the CPU as needed.\n\nROM (Read Only Memory) is used to store critical information like the boot sequence or BIOS/UEFI software or other key info required while the PC is switched on. ROM does not need a constant supply of electricity as it is persistant. data stored on it will be kept when power is disconnected. Data on ROM cannot be written to, altered or deleted in most cases." },
                new List<string> { "The FDE cycle is used to describe the process instructions go through. It all occurs inside the CPU.\n\nFetch: Get the instruction code from memory with a memory adress (a piece of information that tells the CPU where things are in memory).\n\nDecode: Decode the instructions in the processor's registers, depending on the encoding method used.\n\nExecute: Finally the ALU performs the operations on the instuction(s) and stores the output in memory or sends it to an output device." },
            };

            Common.fillListView(hardwareExpandableList, headings, content, Context);

            return view;
        }
    }
}
