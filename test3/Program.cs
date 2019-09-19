using System;

namespace test3
{
    class Program
    {
        static int j = 20;
        static void Main(string[] args)
        {
            int j = 30;
            Console.WriteLine(j);
            

            string s1 = "a string";
            string s2 = s1;
            Console.WriteLine("s1 is" + s1);
            Console.WriteLine("s2 is" + s2);
            s1 = "another string";
            Console.WriteLine("s1 is now " + s1);
            Console.WriteLine("s2 is now " + s2);

            string filepath = @"c:\procsharp\first.cs";
            Console.WriteLine(filepath);
            string aa = @"'twas brillng
        did qe";
            Console.WriteLine(aa);

            int i = 5;
            bool iszero;
            if (i == 0)
            {
                iszero = true;
                Console.WriteLine("i is zero");
            }
            else
            {
                iszero = false;
                Console.WriteLine("i is non-zero");
            }



        }
    }
}
