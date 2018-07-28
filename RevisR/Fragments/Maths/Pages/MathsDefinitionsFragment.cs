using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace RevisR.Fragments.Maths.Pages
{
    public class MathsDefinitionsFragment : Fragment
    {
        private View view;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.maths_def, container, false);

            var buttons = new List<View>
            {
                view.FindViewById(Resource.Id.define_int),
                view.FindViewById(Resource.Id.define_sqnum),
                view.FindViewById(Resource.Id.define_sqroot),
                view.FindViewById(Resource.Id.define_cubenum),
                view.FindViewById(Resource.Id.define_prime),
                view.FindViewById(Resource.Id.define_rational),
                view.FindViewById(Resource.Id.define_reciprocal),
                view.FindViewById(Resource.Id.define_factor),
                view.FindViewById(Resource.Id.define_multiples),
                view.FindViewById(Resource.Id.define_primefactors),
                view.FindViewById(Resource.Id.define_hcf),
                view.FindViewById(Resource.Id.define_lcm),
                view.FindViewById(Resource.Id.define_rounddp),
                view.FindViewById(Resource.Id.define_roundsf),
                view.FindViewById(Resource.Id.define_estimate),
                view.FindViewById(Resource.Id.define_calcbounds),
                view.FindViewById(Resource.Id.define_bounds),
                view.FindViewById(Resource.Id.define_fractodec),
                view.FindViewById(Resource.Id.define_dectofrac),
                view.FindViewById(Resource.Id.define_pcttodec),
                view.FindViewById(Resource.Id.define_fractopct),
            };

            foreach (var b in buttons)
            {
                b.Click += (object sender, EventArgs e) =>
                {
                    defineMaths(b.Id);
                };
            }

            return view;
        }

        public void defineMaths(int id)
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

                    case "Integers":
                        ad.SetMessage("A whole number (no decimals). It can be positive or negative. (e.g NOT 1.5, 13.25, ¼)");
                        break;

                    case "Square Numbers":
                        ad.SetMessage("A number multiplied by itself. (e.g. 3×3=9, 6×6=36)");
                        break;

                    case "Square Roots":
                        ad.SetMessage("This is the inverse (reverse process) of squaring a number. is used. (e.g. 6² = 36, so √36 = 6)");
                        break;

                    case "Cube Numbers/Roots":
                        ad.SetMessage("A number multiplied by itself three times. (The cube root ∛ is the inverse).");
                        break;

                    case "Prime Numbers":
                        ad.SetMessage("A number that has only 2 factors, itself & 1. 2 is the only even prime number. ONE IS NOT A PRIME NUMBER!");
                        break;

                    case "Rational/Irrational Numbers":
                        ad.SetMessage("Rational numbers can be written in the form a/b where a and b are integers. Irrational numbers can't. Pi (π) is an examples of an irrational number.");
                        break;

                    case "Reciprocal":
                        ad.SetMessage("The reciprocal of a number is 1 divided by that number. It is easiest to think about flipping a fraction upside down. (e.g. 1/2 becoming 2/1, or 3 (3/1) becoming 1/3)");
                        break;

                    case "Factors":
                        ad.SetMessage("The integers (whole numbers) that go into a number with no remainder.");
                        break;

                    case "Multiples":
                        ad.SetMessage("Think Times Tables. Just write out the times tables for that number.");
                        break;

                    case "Prime Factors":
                        ad.SetMessage("Numbers can be made up by multiplying prime numbers. (2, 3, 5, 7, 11, 13, 17..). To find the Product of Primes start with a factor tree. Product means multiply so don't forget to put the × sign in between the numbers you found in your factor tree.If you are struggling with the factor tree just keep trying to divide by the prime number in order.Does it divide by 2 ? If so pick 2.If it doesn't divide by 2 does it divide by 3 ? By 5 ? By 7 ? By 11 ? Etc.");
                        break;

                    case "HCF (Highest Common Factor)":
                        ad.SetMessage("The HCF is the largest number that goes into 2 or more different numbers. Method 1: Just list the factors of each and find largest number in each list. Method 2: Using a factor tree, take only the prime numbers that appear in each list of the factors of the numbers to their lowest power and multiply. This method is better for less obvious examples and larger numbers.");
                        break;

                    case "LCM (Lowest Common Multiple)":
                        ad.SetMessage("The lowest (or smallest) number that 2 or more different numbers go in to. Method 1: Just list out the times tables of each number and see which is the lowest number that appears in both lists. This is the LCM. Method 2: Using a factor tree, take all the prime numbers that appear in each list of the factors to their highest power and multiply.");
                        break;

                    case "Rounding to Decimal Places":
                        ad.SetMessage("Make the number have that many decimal places. To do this, look at the decimal place after the max decimal places have been reached. If it is 0.23 to 1DP, you'd look at 3. If the number is 4 or less, then the number must be rounded down, if it is 5 or more, it is rounded up. 0.23 becomes 0.2. 0.25 becomes 0.3.");
                        break;

                    case "Rounding to Significant Figures":
                        ad.SetMessage("When reading a number from left to right the first value that is not 0 in the number is the 1st significant figure. Round the number using the same techniques as used for decimals shown above. With the number 0.043 the 4 is the first significant figure, 3 is the second.");
                        break;

                    case "Estimatings & Approximating":
                        ad.SetMessage("Round each number to 1 significant figure & perform the calculation. You must show workings! Estimating doesn't require the exact value. It's non calculator!");
                        break;

                    case "Calculations with Upper & Lower Bounds":
                        ad.SetMessage("Sometimes you will get a question where the numbers or measurements given have already been rounded. You just need to work out the minimum (Lower Bound) and maximum (Upper Bound) the number could be. One way to think of it is to half the interval given subtract it from the number to find the LB and then add it to the number to get the UB.An example could be 1.4 rounded to one d.p.one d.p = 0.1. If you half this you get 0.05. This gives us a lower bound of 1.35 and an upper bound of 1.45. When you have done this work out which values are required to minimise or maximise the calculation.");
                        break;

                    case "Intervals, Bounds & Error Intervals":
                        ad.SetMessage("You may be asked to interpret or use inequalities for upper and lower bounds. If a number has already been rounded, you may be asked to find the upper and lower bounds of it. One way to do this is to split the interval in half (the interval is 0.1 for 1dp, 0.01 for 2dp, etc.) and add this amount on to the value to get the upper bound and - it for the lower bound.");
                        break;

                    case "Fractions to Decimals":
                        ad.SetMessage("Some are obvious such as ¾ is 0.75. For those that are not, simply divide the numerator (top) by the denominator (bottom) using short division OR use the S>D on your CASIO Scientific Calculator.");
                        break;

                    case "Deciamls to Fractions":
                        ad.SetMessage("Some are obvious such as 0.5 = ½ or 0.75 = ¾ and 0.1 = 1/10 etc. If it's not obvious write it as a fraction over 10, 100 or 1000 and cancel down.");
                        break;

                    case "Percentage & Decimal Conversion":
                        ad.SetMessage("To convert a percentage to a decimal, divide by 100. To convert a decimal to a percentage multiply by 100.");
                        break;

                    case "Fraction & Percentage Conversion":
                        ad.SetMessage("To convert a fraction to a percentage, you can convert it to decimal and then to percentage or use equivilant fractions to get to a denominator of 100. To convert a percentage to a fraction convert the decimal value of the percentage to a fraction over 100/1000. E.g. 73% = 73/100 or 22.8% = 228/1000");
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