using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterRomanToArabicNums
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Converter, enter romanian num: "); string romanianStr = Console.ReadLine();
 
            Console.WriteLine("Arabian num: " + ConverterRomToArabian(romanianStr.ToUpper()));
            Console.ReadLine();
        }

        public static int ConverterRomToArabian (string romanianStr)
        {
            var romanianNums = new Dictionary<char, int>();
            romanianNums.Add('I', 1);
            romanianNums.Add('V', 5);
            romanianNums.Add('X', 10);
            romanianNums.Add('L', 50);
            romanianNums.Add('C', 100);
            romanianNums.Add('D', 500);
            romanianNums.Add('M', 1000);
            
            int result = romanianNums[romanianStr[romanianStr.Length - 1]];

            for (int i = romanianStr.Length - 2; i >= 0; i--)
            {
                if(result <= romanianNums[romanianStr[i]])
                {
                    result += romanianNums[romanianStr[i]];
                }
                else
                {
                    result -= romanianNums[romanianStr[i]];
                }
            }

            
            return result;
        }

    }
}
