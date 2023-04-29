using System;
using System.Linq;

namespace Narcissistic_Number
{
    class Program
    {
        /*
        
        A Narcissistic Number (or Armstrong Number) is a positive number which is the sum of its own digits, each raised to the power of the number of digits in a given base. In this Kata, we will restrict ourselves to decimal (base 10).
        For example, take 153 (3 digits), which is narcissistic:
        1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
        and 1652 (4 digits), which isn't:
        1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938
          
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine(Narcissistic(371));
            Console.WriteLine(Narcissistic(1));
            Console.WriteLine(Narcissistic(1652));

            Console.ReadLine();
        }

        public static bool Narcissistic(int value)
        {
            var valueStr = value.ToString().ToList();
            long sum = 0;

            valueStr.ForEach(charValue => {
                sum += (long)Math.Pow(
                    (double)Int32.Parse(charValue.ToString())
                   , (double)value.ToString().Length); });

            return sum.Equals(value);
            
        }
    }
}
