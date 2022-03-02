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
        private void OutputHeading()
        {
            throw new Not
            Console.WriteLine();
            Console.WriteLine(" ------------------------- ");
            Console.WriteLine("  Convert  Miles to Feet   ");
            Console.WriteLine("      by Teddie Roden      ");
            Console.WriteLine(" ------------------------- ");
            Console.WriteLine();
        }
        private void ConvertMilesToFeet()
        {
            OutputHeading();
            InputMiles();

            feet = miles * FEET_IN_MILES

            OutputFeet();
        }
    }
}
