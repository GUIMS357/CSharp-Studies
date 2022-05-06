using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varivaies
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */
            Console.WriteLine("seu nome é?");

            Console.Write("type your first name");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //Console.Write("type your last name");
            //string myLastName;
            // myLastName = Console.ReadLine();

            Console.Write("type your last name");
            string myLastName = Console.ReadLine();


            Console.WriteLine("hello, " + myFirstName +"  "+ myLastName);
            Console.ReadLine();

        }
    }
}
