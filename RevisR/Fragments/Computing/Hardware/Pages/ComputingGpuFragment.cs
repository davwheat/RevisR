using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace RevisR.Fragments.Computing.Hardware.Pages
{
    class ComputingGpuFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.computing_hardware_gpu, container, false);

            // Set the expandablelistview variable for use in other functions
            var hardwareExpandableList = (ExpandableListView)view.FindViewById(Resource.Id.computingHardwareGpuExpandableList);

            var headings = new List<string>
            {
                "What is a GPU?",
                "Cryptocurrency Mining",
            };

            var content = new List<List<string>>
            {
                // \n is a new line
                new List<string> { "A GPU is a processor dedicated to quickly rendering (normally 3D) graphics. It can be many tens of times faster than a CPU at processing a variety of different calculations, whereas a GPU is best at focusing all the computational power on one specific task. That is because a CPU consists of a few cores (up to 24) optimized for sequential serial processing. It is designed to maximize the performance of a single task within a job; however, the range of tasks is wide. On the other hand, a GPU uses thousands of smaller and more efficient cores for a massively parallel architecture aimed at handling multiple functions at the same time.\n\nModern GPUs provide superior processing power, memory bandwidth and efficiency over their CPU counterparts. They are 50–100 times faster in tasks that require multiple parallel processes, such as machine learning and big data analysis." },
                new List<string> { "In recent years, cryptocurrency mining has become overwhelmingly popular. Cryptocurrency mining was originally performed using CPUs. However, its limited processing speed and high power consumption led to limited output, rendering the CPU-based mining process inefficient.\n\nGPU-based mining offerend many beneifts over the use of a CPU. Even an older GPU like the AMD/ATi Radeon HD 5970 runs at 3200 32-bit instructions per clock compared to the mere 4 instructions per clock on a CPU.\n\nThe core reason behind this efficiency is that the video processing GPUs are devised to do better in performing similar and repetitive work, than in performing diversified multi-tasking functions like those of the CPU. For example, rendering a 3D movie requires the GPU to keep processing similar kinds of information to the screen again and again, though with slight changes.\n\nIt is this property of the GPU that makes them suitable and better for cryptocurrency mining, as the mining process requires higher efficiency in performing similar kinds of repetitive computations. The mining device continuously tries to decode the different hashes repeatedly with only one digit changing in each attempt in the data that is getting hashed. A GPU fits better for such dedicated processing.\n\nGPUs are also equipped with a large number of Arithmetic Logic Units(ALU), which are responsible for performing mathematical computations. Courtesy of these ALUs, the GPU is capable of performing more calculations, leading to improved output for the crypto mining process." },
            };

            Common.fillListView(hardwareExpandableList, headings, content, Context);

            return view;
        }
    }
}
