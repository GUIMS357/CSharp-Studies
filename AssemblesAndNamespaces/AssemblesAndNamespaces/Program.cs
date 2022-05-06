using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//remove necessidade de colocar  
using System.Net;

namespace AssemblesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("Http://msdn.microsoft.com");

            System.Console.WriteLine(reply);
            File.WriteAllText(@"D:\C# teste", reply);

            Console.ReadLine();
        }

    }
}
