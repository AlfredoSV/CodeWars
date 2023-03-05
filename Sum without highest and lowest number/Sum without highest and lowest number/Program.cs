using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_without_highest_and_lowest_number
{
    internal class Program
    {
        /*
         
        Task
        Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element 
        ( by value, not by index! ).

        The highest or lowest element respectively is a single element at each edge, even if there 
        are more than one with the same value.

        Mind the input validation.

        Example
        { 6, 2, 1, 8, 10 } => 16
        { 1, 1, 11, 2, 3 } => 6

        Input validation
        If an empty value ( null, None, Nothing etc. ) is given instead of an array, 
        or the given array is an empty list or a list with only 1 element, return 0.


         
         */


        static void Main(string[] args)
        {

            Console.WriteLine(Sum(null));
            Console.Read();
        }

        public static int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;
            if (numbers.Length == 0 || numbers.Length == 1)
                return 0;
            Array.Sort(numbers);

            return numbers.Sum() - numbers[0] - numbers[numbers.Length-1];
           
            
        }
    }
}
