using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_BMR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to BMI and BMR calculator\r\n");
            Console.WriteLine("BMI table\r\nThe table below applies to men and women over 18 years of age with a normal body build.\n" +
                            "\r\nBMI below 18.5 \t-underweight" +
                            "\r\nBMI 18.5–25 \t-healthy and normal weight" +
                            "\r\nBMI 25–30 \t-overweight" +
                            "\r\nBMI 30–40 \t-severely overweight" +
                            "\r\nBMI over 40 \t-extremendously overweight");

            Console.WriteLine();
            Console.Write("Please select gender (Female: 0, Male: 1): ");
            int sex = Convert.ToInt32(Console.ReadLine());

            //Gender selection check.
            if (sex == 0 || sex == 1)
            {
                Console.Write("Please enter your age (18-70): ");
                int age = Convert.ToInt32(Console.ReadLine());

                //Age range check
                if (18 <= age && age <= 70)
                {
                    Console.Write("Please enter your weight (50-300kg): ");
                    int weight = Convert.ToInt32(Console.ReadLine());

                    if (weight > 50 && weight < 220) // weight should be between 50 and 220 kg.
                    {
                        Console.Write("Please write your height (10-250cm): ");
                        int height = Convert.ToInt32(Console.ReadLine());

                        if (height > 10 && 250 > height) // the height should be between 10 and 250 cm.
                        {
                            double bmi = Math.Round((1.3 * weight / Math.Pow((height / 100D), 2.5)), 1); //BMI formula and display 1 digit after decimal point
                            Console.WriteLine(); //We leave a blank line to increase readability.

                            Console.WriteLine("Congratulations! Your BMI and BMR values ​​have been calculated: ");
                            if (bmi < 18.5)
                            {
                                Console.WriteLine("Your IBM: " + bmi + " - Underweight");
                            }
                            else if (18.5 <= bmi && bmi < 25)
                            {
                                Console.WriteLine("Your IBM: " + bmi + " - Healthy and Normal Weight");
                            }
                            else if (25 <= bmi && bmi < 30)
                            {
                                Console.WriteLine("Your IBM: " + bmi + " - Overweight");
                            }
                            else if (30 <= bmi && bmi < 40)
                            {
                                Console.WriteLine("Your IBM: " + bmi + " - Severely Overweight");
                            }
                            else if (40 <= bmi)
                            {
                                Console.WriteLine("Your IBM: " + bmi + " - Extreme Overweight");
                            }
                            else
                            {
                                Console.WriteLine("Invalid value!");
                            }

                            //BMR Calculation
                            if (sex == 0)
                            {
                                //Woman
                                double bmrFemale = 655.1 + (9.563 * weight) + (1.85 * height) - (4.676 * age);
                                Console.WriteLine("Your BMR: " + bmrFemale);
                            }
                            else
                            {
                                //Men
                                double bmrMale = 66.47 + (13.75 * weight) + (5.003 * height) - (6.755 * age);
                                Console.WriteLine("Your BMR: " + bmrMale);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid height!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid, please enter a value between 50 and 300kg.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid age value. Please enter a value between 18-70.");
                }

            }
            else
            {
                Console.WriteLine("Invalid gender value.");
            }

            Console.WriteLine("");
        }
    }
}