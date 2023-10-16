﻿using System;
using System.Collections.Generic;
using System.Globalization;
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

                        if (ValidateInput(romanianStr.ToUpper()))
                            Console.WriteLine("Arabian num: " + ConverterRomToArabian(romanianStr.ToUpper()));
                        else
                            Console.WriteLine("Error! invalid symbol. Try Again");
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

        public static string ConverterArabToRomanian(int number)
        {
            string result = string.Empty;

            return result;
        }
    }
}
