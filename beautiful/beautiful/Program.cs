using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beautiful
{
    class Program
    {
        static void Main(string[] args)
        {
            //To change the color of the text .
            Console.ForegroundColor = ConsoleColor.White;

                
            Console.WriteLine("Please enter your first name");
            string  Fname = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
                string  Lname = Console.ReadLine();

            /*string concatenation*/
            Console.WriteLine(Fname + " " + Lname);

            //replacement method.
            Console.WriteLine("{0} {1}", Fname, Lname);

            //Dollar sign method.
            Console.WriteLine($"{Fname} {Lname}");

            Console.ReadLine();

            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();

            Console.WriteLine("Write your address here");
            string address = Console.ReadLine();

            Console.WriteLine("Write your email address here");
            string Emailaddress = Console.ReadLine();

            Console.WriteLine("Write your age here");
            int age = int.Parse(Console.ReadLine());

            //giving a heading.
            Console.WriteLine("**********Personal information * *****");
            Console.WriteLine($"{username}\n{address}\n{Emailaddress}\n{age}");
            Console.ReadLine();


        }
    }
}
