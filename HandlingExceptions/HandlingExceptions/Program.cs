using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string content = File.ReadAllText(@"C:\Lesson_22\Exampl.txt");
                Console.WriteLine(content);
                
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly:Example.txt");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the directory c:\Lessons_22 exsists");
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Code to finalize
                //SEtting objects to NULL
                //Closing database copnections
                Console.WriteLine("clossing aplication now...");
            }
            Console.ReadLine();
        }
    }
}
