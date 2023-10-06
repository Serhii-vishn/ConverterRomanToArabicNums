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

        public static bool ValidateInput(string input)
        {
            foreach (char c in input)
            {
                if (!romanianNums.ContainsKey(c))
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\t\tConverter Roman to arabian numbers");
                Console.WriteLine("\t--------------------------------------------------");
                Console.Write("Enter romanian num: "); string romanianStr = Console.ReadLine();

                if (ValidateInput(romanianStr))
                    Console.WriteLine("Arabian num: " + ConverterRomToArabian(romanianStr.ToUpper()));
                else
                    Console.WriteLine("Error! invalid symbol. Try Again");

                Console.Write("\nExit - *, complete - any: "); var k = Console.ReadKey();
                if (k.KeyChar == '*')
                    break;
            }
        }

        public static int ConverterRomToArabian (string romanianStr)
        {       
            int lastNum = romanianStr.Length - 1;
            
            int nxtArabian = romanianNums[romanianStr[lastNum]];
            int result = romanianNums[romanianStr[lastNum]];

            for (int i = lastNum - 1; i >= 0; i--)
            {
                int currArabian = romanianNums[romanianStr[i]];
                if(currArabian < nxtArabian)
                {
                    result -= currArabian;
                }
                else
                {
                    result += currArabian;
                }
                nxtArabian = currArabian;
            }           
            return result;
        }
    }
}
