using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 200;
            int level = 3;
            int nItems = 4;

            int score_new, level_new;
            
            // increase score and level 
            score_new = score + 1;
            level_new = level +1;

            Console.WriteLine("Score (old): {0}, score (new): {1}", score, score_new);
            Console.WriteLine("level (old): {0}, level (new): {1}", level, level_new);

            nItems += 5;
            Console.WriteLine("number of items: {0}", nItems);

            //wait for user to press a key
            Console.ReadKey();

        }
    }
}
