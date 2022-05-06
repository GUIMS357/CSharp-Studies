﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndestandingScopes
{
    class Program
    {
        private static string k = " ";

        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if(i==9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l);
            }
            //Console.WriteLine(i);
            Console.WriteLine("outside of the for: " + j);
            Console.WriteLine("outside of the for: " + k);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething(); 

            Console.ReadLine();
        }
        static void HelperMethod()
        {
            Console.WriteLine("Value of K from the helperMethod():" + k);
        }

        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(HelperMethod());
            }
            private string HelperMethod()
            {
                return "Hello world!";
            }

        }
    }
}
