﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe un numero");
            int n = Int32.Parse(Console.ReadLine());
            if (n % 2 != 0) { Console.WriteLine("Weird"); }
            if (n % 2 == 0 && n > 2 && n < 5) { Console.WriteLine("Not Weird"); }
            if (n % 2 == 0 && n > 6 && n < 20) { Console.WriteLine("Weird"); }
            if (n % 2 == 0 && n > 20) { Console.WriteLine("Not Weird"); }
        }
    }
}
