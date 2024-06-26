﻿using System;
using System.Collections.Specialized;
using zd_3;

namespace zd_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //before we construct a submarine, test individual elements of the program first
            bool testsPassed = TestSubmarine.Run();
            if (!testsPassed) return;
            Console.WriteLine();
            // uncomment this if you are ready for the submarine simulation
            Submarine.Demo();

        }
    }
}
