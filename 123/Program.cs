﻿using System;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "bugs bunny";
            var age = 25;
            var israbbit = true;

            Type nametype = name.GetType();
            Type agetype = age.GetType();
            Type israbbittype= israbbit.GetType();

            Console.WriteLine("name is type" + nametype.ToString());
            Console.WriteLine("age is type" + agetype.ToString());
            Console.WriteLine("israbbit is type" + israbbit.ToString());

        }
    }
}
