﻿using System.Collections.Generic;

using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using ImageViews.Photo;

namespace RevisR.Fragments.Computing.Hardware.Pages
{
    class ComputingMoboFragment : Fragment
    {
        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.computing_hardware_mobo, container, false);

            // Set the expandablelistview variable for use in other functions
            var hardwareExpandableList = view.FindViewById<ExpandableListView>(Resource.Id.computingHardwareMoboExpandableList);

            var headings = new List<string>
            {
                "What is a Motherboard?",
                "Component Communication",
                "What is on a Motherboard?",
            };

            var content = new List<List<string>>
            {
                // \n is a new line
                new List<string> { "Alternatively referred to as the mb, mainboard, mboard, mobo, main circuit board, logic board on Apple computers. The motherboard is a printed circuit board that is the foundation of a computer, located on the back side or at the bottom of the computer chassis. It allocates power and allows communication to the CPU, RAM, and all other computer hardware components." },
                new List<string> { "Everything in the computer case is connected in some way to the motherboard. This allows all the components to communicate to each other.\n\nThis includes GPUs, HDDs, SSDs, ODDs (CD Drives), RAM, CPU and more. Even the fans are plugged into the motherboard." },
                new List<string> { "There are many components on a motherboard. These include:\nI/O (Input/Output) Ports: usually found on the back of the PC Case. These include audio, USB, display, PS-2 connectors, Ethernet (RJ45) and more.\nBIOS: This means 'Basic Input/Output System' and it is the chip that contains information and the settings of the motherboard. This replaced the now outdated system of pins, jumper connections and dip switches. A more modern version of this is also now in use called UEFI (also known as the UEFI BIOS). This provides mouse support whereas only keyboard could be used in the BIOS.\nCMOS: The CMOS stores the BIOS settings. There is also a CMOS battery that provides a electrical current to the CMOS so the volatile memory does not lose its data.\nCPU Socket: There are many types of CPU socket, including LGA (land grid array), PGA (pin grid array) and BGA (ball grid array). LGA is used on most Intel CPUs. In LGA the pins are on the motherboard and there are flat landing pads on the bottom of the CPU. In PGA, the pins are on the mosstom of the CPU. Some argue that this makes the chip more durable, but others argue that it's more expensive to repair/replace if a pin breaks. PGA CPUs are somewhat easier to install becuase they fall directly into place and there is less risk of damaging the component. BGA is more commonly used in laptops and mobile devices. There are notably used in Apple Products but they can be found in other places too. BGA packages have balls of solder between the chip and motherboard that melt when heat is applied. This is often a one way process and it is often easier to replace the whole board than to remelt the solder, clean the motherboard and chip, then reapply the balls of solder (which are often 1mm in size) and remelt them. The number after the socket (e.g. LGA2011, LGA1156) dictates the number of pins/landing areas on the socket.\nRAM Slots: Most motherboards have 2, 4 or 8 of these slots. They are positioned next to the CPU socket on most motherboards. More details about RAM itself is available under the RAM section of Computer Hardware. There are two types of slot: SIMM (obsolete) and DIMM (current standard). DIMM means Double Inline Memory Module. These are the ones used in modern computers. In laptops these are referred to as SO-DIMM slots.\nExpansion Card Slots: These slots are used to add new interface cards or expansion cards to the system. These could be Sound Cards, GPUs, NICs or more. These are 3 main types of slot, with only one being a current standard. ISA slots are the oldest, followed by PCI slots then by PCIe/PCI Express slots. PCIe is the most common and is the fastest of all of these. You can get PCIe x1, x2, x4, x8 or x16 slots. These numbers refer to the number of pins on that slot. ALL cards can be used in ALL slots if you so wish, but to fit an x16 card in an x1 slot it would require slight destruction of the slot. This can be seen in a LinusTechTips video from 2012: https://www.youtube.com/watch?v=fZed5r9tXHQ&ab_channel=LinusTechTips\nStorage Device Connectors: These connect to HDDs, CD Drives and SSDs via IDE (old) or SATA (modern) to allow communication between these components and the motherboard.\nPower Connectors: Motherboards need power to function. This is normally suppied via ATX Power Connectors from the PSU." },
            };

            Common.fillListView(hardwareExpandableList, headings, content, Context);

            return view;
        }
    }
}