using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisão
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string message=" ";

            Console.WriteLine("bob's big giveaway");
            Console.WriteLine("choose dor 1,2 or 3");
            string userValue = Console.ReadLine();

            if(userValue == "1")           
                message = "ÿou won a new car";          
            else if(userValue =="2")           
                message = "you won a new boat";          
            else if (userValue == "3")           
                message = "you won a new cat";           
            else
            {
                message = "sorry we didn't understand";
                // message = message + "you lose";
                message += "you lose.";
            }

            Console.WriteLine(message);

            Console.ReadLine();
            */

            Console.WriteLine("bob's big giveaway");
            Console.WriteLine("choose dor 1,2 or 3");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" :  "strand of lint";

            //Console.Write("you won a ");
            // Console.Write(message);
            //Console.Write(".");

            Console.WriteLine("you entred {0} you won a {1}.",userValue, message);
            Console.ReadLine();
        }
    }
}
