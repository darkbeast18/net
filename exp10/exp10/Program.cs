﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First string : ");

            String s1 = Console.ReadLine();

            Console.WriteLine("Enter second string: ");
             String s2 = Console.ReadLine();

            Console.WriteLine(s1.ToUpper());

            Console.WriteLine(s2.ToLower());

            Console.ReadLine();
        }
    }
}
