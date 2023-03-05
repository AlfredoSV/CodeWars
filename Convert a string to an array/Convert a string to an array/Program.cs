using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_a_string_to_an_array
{
    internal class Program
    {



        /*
         
        Write a function to split a string and convert it into an array of words.

        Examples (Input ==> Output):
        "Robin Singh" ==> ["Robin", "Singh"]

        "I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
         
         */
        static void Main(string[] args)
        {

            var res = StringToArray("Hola Alfredo");

        }

        public static string[] StringToArray(string str)
        {
            return str.Split(' ');
        }
    }
}
