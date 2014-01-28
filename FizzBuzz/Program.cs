using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {

            string userYN = "y";
            int check;
            int userInput = 0;

            while (userYN == "y")
            {
                Console.WriteLine("Please enter number to check the next ten numbers of FizzBuzz game");
                while (!Int32.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("The number you input is invalid. Try again.");
                }

                Console.WriteLine("********************************************************************");
                check = userInput;
                for (int i = 0; i < 10; i++)
                {
                    check = userInput + i;
                    if ((check % 5 == 0) && (check % 3 == 0))
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (check % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (check % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(check);
                    }
                }
                Console.WriteLine("Would you like to check another 10 numbers?");
                char[] charArray = Console.ReadLine().ToCharArray();
                userYN = ("" + char.ToLower(charArray.ElementAt(0)));

                while (userYN != "y" && userYN != "n")
                {
                    Console.WriteLine("Not a valid Answer. Try Again");
                    charArray = Console.ReadLine().ToCharArray();
                    userYN = ("" + char.ToLower(charArray.ElementAt(0)));
                }
            }
        }
    }
}
