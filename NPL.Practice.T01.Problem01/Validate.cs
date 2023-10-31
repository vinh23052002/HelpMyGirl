using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.Practice.T01.Problem01
{
    internal class Validate
    {
        public static int ValidateNumber(string character)
        {
            while (true)
            {
                Console.Write(character);
                string StringInput = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(StringInput))
                    {
                        Console.Write("The " + character + " must not be empty!\nEnter a number again: ");
                    }
                    else
                    {
                        int InputNumber = int.Parse(StringInput);
                        if (InputNumber < 0)
                        {
                            Console.WriteLine("Invalid number! The " + character + " must be equal or greater than 0!");
                            Console.Write("Enter a number again: ");
                        }
                        else return InputNumber;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number! The " + character + " must be equal or greater than 0!");
                    Console.Write("Enter a number again: ");
                }
            }
        }
        public static int ValidateNumberInArray(string character)
        {
            while (true)
            {
                string StringInput = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(StringInput))
                    {
                        Console.Write("The " + character + " must not be empty!\nEnter a number again: ");
                    }
                    else
                    {
                        int InputNumber = int.Parse(StringInput);
                        if (InputNumber < 0)
                        {
                            Console.WriteLine("Invalid number! The " + character + " must be equal or greater than 0!");
                            Console.Write("Enter a number again: ");
                        }
                        else return InputNumber;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number! The " + character + " must be number!");
                    Console.Write("Enter a number again: ");
                }
            }
        }
    }
}
