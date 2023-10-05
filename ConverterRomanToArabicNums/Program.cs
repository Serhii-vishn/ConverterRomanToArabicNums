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

            int lastNum = romanianStr.Length - 1;
            int result = romanianNums[romanianStr[lastNum]];
            int arabian;
            for (int i = lastNum - 1; i >= 0; i--)
            {
                arabian = romanianNums[romanianStr[i]];
                if(arabian < romanianNums[romanianStr[i+1]])
                {
                    result -= arabian;
                }
                else
                {
                    result += arabian;
                }
            }           
            return result;
        }
    }
}
