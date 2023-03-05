using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accum("cwAt"));

            Console.Read();
        }

        public static String Accum(string s)
        {
            var strRes = new StringBuilder();
            var temCar = String.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                temCar = s[i].ToString();
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                        strRes.Append(temCar.ToUpper());
                    else
                        strRes.Append(temCar.ToLower());
                }
                strRes.Append("-");
            }

            return strRes.ToString().Trim('-');
        }


    }
}
