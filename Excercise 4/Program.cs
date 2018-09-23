using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            bool tooOld;
            tooOld = age > 65;


            Console.WriteLine("boolean answer: {0} ", tooOld);

            Console.ReadKey();




    

        }
    }
}
