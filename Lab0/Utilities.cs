using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    /// <summary>
    /// Methods for getting and validating input data and relevant calculation
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// reads positive decimal
        /// </summary>
        /// <param name="prompt"> name used in error messages</param>
        /// <returns>decimal value read that is > 0</returns>
        public static decimal GetPositiveDecimal(string prompt)
        {
            bool gotIt = false;
            decimal result = 0;
            string input;

            while (!gotIt)
            {
                Console.WriteLine($"Enter {prompt}:");
                input = Console.ReadLine() ?? "";

                if (Decimal.TryParse(input, out result))
                {
                    if (result > 0)
                    {
                        gotIt = true;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {prompt} must be positive");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {prompt} must be a number");
                }
            }
            return result;
        }

        /// <summary>
        /// reads positive int
        /// </summary>
        /// <param name="prompt"> name used in error messages</param>
        /// <returns>int value read that is > 0</returns>
        public static int GetPositiveInt(string prompt)
        {
            bool gotIt = false;
            int result = 0;
            string input;

            while (!gotIt)
            {
                Console.WriteLine($"Enter {prompt}:");
                input = Console.ReadLine() ?? "";

                if (Int32.TryParse(input, out result))
                {
                    if (result > 0)
                    {
                        gotIt = true;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {prompt} must be positive");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {prompt} must be a number");
                }
            }
            return result;
        }

        /// <summary>
        /// reads int in range
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <param name="minValue">minimum value for the range</param>
        /// <param name="maxValue">maximum value for the range</param>
        /// <returns>int value read that is within range</returns>
        public static int GetIntInRange(string prompt, int minValue, int maxValue)
        {
            bool gotIt = false;
            int result = 0;
            string input;

            while (!gotIt)
            {
                Console.WriteLine($"Enter {prompt}:");
                input = Console.ReadLine() ?? "";

                if (Int32.TryParse(input, out result))
                {
                    if (result >= minValue && result <= maxValue)
                    {
                        gotIt = true;
                    }
                    else
                    {
                        if (minValue == Int32.MinValue)
                            Console.WriteLine($"Error: {prompt} must be less than or equal to {maxValue}");
                        else if (maxValue == Int32.MaxValue)
                            Console.WriteLine($"Error: {prompt} must be greater than or equal to {minValue}");
                        else
                            Console.WriteLine($"Error: {prompt} must be within range {minValue} - {maxValue}");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {prompt} must be a number");
                }
            }
            return result;
        }

        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    } // class
} // namespace
