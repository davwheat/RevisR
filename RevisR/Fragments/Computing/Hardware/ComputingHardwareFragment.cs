using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace RevisR.Fragments.Computing.Hardware
{
    internal class ComputingHardwareFragment : Fragment
    {
        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.computing_hardware, container, false);

            ((TextView)view.FindViewById(Resource.Id.computingHardwareCpuButton)).Click += openComputingHardwareCpu;
            ((TextView)view.FindViewById(Resource.Id.computingHardwareGpuButton)).Click += openComputingHardwareGpu;
            ((TextView)view.FindViewById(Resource.Id.computingHardwareMoboButton)).Click += openComputingHardwareMobo;
            ((TextView)view.FindViewById(Resource.Id.computingHardwareHddButton)).Click += openComputingHardwareHdd;
            ((TextView)view.FindViewById(Resource.Id.computingHardwareSsdButton)).Click += openComputingHardwareSsd;
            ((TextView)view.FindViewById(Resource.Id.computingHardwareRamButton)).Click += openComputingHardwareRam;
            ((TextView)view.FindViewById(Resource.Id.computingHardwareCaseButton)).Click += openComputingHardwareCase;
            ((TextView)view.FindViewById(Resource.Id.computingHardwarePsuButton)).Click += openComputingHardwarePsu;

            return view;
        }

        public void openComputingHardwareCpu(object sender, EventArgs e)
        {
            Fragment fragment = new Pages.ComputingCpuFragment();
            var fragmentTransaction = FragmentManager.BeginTransaction();
            fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            fragmentTransaction.AddToBackStack(null);
            fragmentTransaction.Commit();
        }

        public void openComputingHardwareGpu(object sender, EventArgs e)
        {
            //Fragment fragment = new Pages.ComputingCpuFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Common.notImplementedWarning(view, Context);
        }

        public void openComputingHardwareMobo(object sender, EventArgs e)
        {
            //Fragment fragment = new Pages.ComputingCpuFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Common.notImplementedWarning(view, Context);
        }

        public void openComputingHardwareHdd(object sender, EventArgs e)
        {
            //Fragment fragment = new Pages.ComputingCpuFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Common.notImplementedWarning(view, Context);
        }

        public void openComputingHardwareSsd(object sender, EventArgs e)
        {
            //Fragment fragment = new Pages.ComputingCpuFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Common.notImplementedWarning(view, Context);
        }

        public void openComputingHardwareRam(object sender, EventArgs e)
        {
            //Fragment fragment = new Pages.ComputingCpuFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Common.notImplementedWarning(view, Context);
        }

        public void openComputingHardwareCase(object sender, EventArgs e)
        {
            //Fragment fragment = new Pages.ComputingCpuFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Common.notImplementedWarning(view, Context);
        }

        public void openComputingHardwarePsu(object sender, EventArgs e)
        {
            //Fragment fragment = new Pages.ComputingCpuFragment();
            //var fragmentTransaction = FragmentManager.BeginTransaction();
            //fragmentTransaction.Replace(Resource.Id.framecontainer, fragment);
            //fragmentTransaction.AddToBackStack(null);
            //fragmentTransaction.Commit();
            Common.notImplementedWarning(view, Context);
        }
    }
}
