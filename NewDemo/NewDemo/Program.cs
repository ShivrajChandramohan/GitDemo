﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GitDemo gitDemo = new GitDemo();
            
            gitDemo.Demo();

            //Console.ReadLine();

            UC2_Demo uc2_Demo = new UC2_Demo();

            uc2_Demo.demo();

            Console.ReadLine();
        }
    }
}
