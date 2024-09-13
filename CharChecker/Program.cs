using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEnter a letter or press Q to quit the program");
                char letter = Console.ReadKey().KeyChar;
                if (letter == 'Q')
                {
                    break; //exits the loop
                }
                else if (Char.IsLetter(letter))
                    {
                    if (Char.IsLower(letter))
                    {
                        Console.WriteLine(" Is a lower case letter");
                    }
                    else
                    {
                        Console.WriteLine(" Is a upper case letter");
                    }
                
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid character ex:(A,b,c)");
                }
                Console.WriteLine("Press Enter to continue");
                Console.ReadKey();
                
            }
        }
    }
}
