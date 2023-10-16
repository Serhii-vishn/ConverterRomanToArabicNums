using System;
using System.Collections.Generic;
using System.Linq;

namespace ConverterRomanToArabicNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\n\t\tConverter Roman/Arabian numbers");
                Console.WriteLine("\t--------------------------------------------------");

                Console.WriteLine("Convert:" +
                                        "\n\tRoman to Arabic - 1" +
                                        "\n\tArabic to Roman - 2" +
                                        "\n\tExit - *");
                Console.Write("\tEnter: "); var k = Console.ReadKey();
                Console.WriteLine("\n");

                switch (k.KeyChar)
                {
                    case '1':
                    {
                        Console.Write("Enter romanian num: "); string romanianStr = Console.ReadLine();

                        if (ConverterRomToArabian(romanianStr.ToUpper()) > 0)
                            Console.WriteLine("Arabian num: " + ConverterRomToArabian(romanianStr.ToUpper()));
                        break;
                    }
                    case '2':
                    {
                        Console.Write("Enter arabian num: "); int arabianNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Romanian num: " + ConverterArabToRomanian(arabianNum));
                        break;
                    }
                    case '*':
                    {
                        Console.WriteLine("\t\tThank you for using, have a nice day ;)");
                        Console.WriteLine("\t-------------------------------------------------------");
                        Console.ReadLine();
                        return;
                    }
                    default:
                    {
                        Console.WriteLine("Error! Invalid symbol. Try Again");
                        break;
                    }
                }
                Console.ReadLine();
            }
        }

        public static int ConverterRomToArabian (string romanianStr)
        {
            Dictionary<char, int> romanianNums = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'M', 1000}
            };
            int result = 0;
            if (ValidateInput(romanianStr.ToUpper(), romanianNums))
            {
                int lastNum = romanianStr.Length - 1;

                int nxtArabian = romanianNums[romanianStr[lastNum]];
                result = romanianNums[romanianStr[lastNum]];

                for (int i = lastNum - 1; i >= 0; i--)
                {
                    int currArabian = romanianNums[romanianStr[i]];
                    if (currArabian < nxtArabian)
                    {
                        result -= currArabian;
                    }
                    else
                    {
                        result += currArabian;
                    }
                    nxtArabian = currArabian;
                }
            }
            else
            {
                Console.WriteLine("Error! invalid symbol. Try Again");
            }            
            return result;
        }

        public static bool ValidateInput(string input, Dictionary<char, int> romanianNums)
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

        public static string ConverterArabToRomanian(int number)
        {
            string result = string.Empty;
            Dictionary<string, int> arabicNums = new Dictionary<string, int>()
            {
                {"I", 1},
                {"IV", 4},
                {"V", 5},
                {"IX", 9},
                {"X", 10},
                {"XL", 40},
                {"L", 50},
                {"XC", 90},
                {"C", 100},
                {"CD", 400},
                {"D", 500},
                {"CM", 900},
                {"M", 1000}
            };

            foreach (var paitNums in arabicNums.OrderByDescending(x => x.Value))
            {
                while (number >= paitNums.Value)
                {
                    result += paitNums.Key;
                    number -= paitNums.Value;
                }
            }
            return result;
        }
    }
}
