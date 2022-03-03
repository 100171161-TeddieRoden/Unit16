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

        }
        private void OutputFeet()
        {

        }

    }
}
