using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
                //here a EnvironmentVariableTarget 'name' is declared
                //this variable will be used later
                string name;

                //read the name of the user and store this in the variable 'name'
                name = Console.ReadLine();

                //read the age of the user and store this in the variable 'age'
                //the variable is immediately also declared
                string age = Console.ReadLine();

                //show the name and age again on the screen
                Console.WriteLine("Your name is {0}", name);
                Console.WriteLine("Your age is {0}", age);

            //wait for user to press a key
            Console.ReadLine();





        }
    }
}
