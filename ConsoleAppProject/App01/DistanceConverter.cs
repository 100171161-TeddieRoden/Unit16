using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// A Distance converter
    /// </summary>
    /// <author>
    /// Teddie Roden version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        
        private double miles;

        private double feet;

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// prompt user to input miles
        /// input miles as a double 
        /// </summary>

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" --------------------------------------- ");
            Console.WriteLine(" Convert Miles To Feet                   ");
            Console.WriteLine(" By Teddie Roden                         ");
            Console.WriteLine(" --------------------------------------- ");
            Console.WriteLine();
        }

        public void ConvertMilesToFeet()
        {
            OutputHeading();
            InputMiles();

            feet = miles * FEET_IN_MILES;

            OutputFeet();
        }

        private void InputMiles()
        {
            Console.Write("Please Enter The Number Of Miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

    }
}
