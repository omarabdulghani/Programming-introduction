using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //read the age of the user
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            //convert the text to an integer (int) 
            int age = int.Parse(input);

            //now we can perform calculations with the (int) age
            //this was not possible with the string value 
            age = age + 1;

            //convert an integer to text
            string output = age.ToString();

            //show the increased age on the screen
            Console.WriteLine("Next year you will be {0} years old.", age);

            //wait for user to press a key
            Console.ReadKey();

        }
    }
}
