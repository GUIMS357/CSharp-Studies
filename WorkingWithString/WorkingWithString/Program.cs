using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "";
            // string myString = "My \"so-called\" life";
            //string myString = "What if I need a \n new line";

            //string myString = "Go to your c:\\ drive ";
            //string myString = @"go to your c:\drive";

            //string myString = String.Format("{0} = {1}", "First", "second");

            //string myString = string.Format("{0:C}", 123.45); :C para add R$
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("percentage: {0:P}", .123);
            //string myString = string.Format("{0:(###) ###-####}", 1234567890);

            //string myString = " That summer we took therees acros the bords  ";

            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            //myString = string.Format("Lenght before : {0}--Lenght afte: {1}",
            //myString.Length,
            // myString.Trim().Length);


            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder

             for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(1);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
