﻿using System;
//using JsonClass;

namespace TestSourceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Payload();
            var y = x.Dict;
            Console.WriteLine("Types in this assembly:");
            foreach (Type t in typeof(Program).Assembly.GetTypes())
            {
                Console.WriteLine(t.FullName);
            }
        }
    }
}
