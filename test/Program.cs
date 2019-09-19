using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type in a string");
            string input;
            input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("you typed in an empty string");
            }
            else if (input.Length < 5)
            {
                Console.WriteLine("the string had less than  5 characters");
            }
            else if (input.Length < 10)
            {
                Console.WriteLine("the string had at least 5 but less than 10 chart");

            }
            Console.WriteLine("the string was " + input);


        }
    }
}
