using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterRomanToArabicNums
{
    internal class Program
    {
        public static Dictionary<char, int> romanianNums = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'M', 1000}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("\t\tConverter Roman to arabian numbers");
            Console.WriteLine("\t--------------------------------------------------");
            Console.Write("Enter romanian num: "); string romanianStr = Console.ReadLine();
 
            Console.WriteLine("Arabian num: " + ConverterRomToArabian(romanianStr.ToUpper()));
            Console.ReadLine();
        }

        public static int ConverterRomToArabian (string romanianStr)
        {       
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
