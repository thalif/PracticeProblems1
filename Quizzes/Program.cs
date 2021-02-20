using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string inputscore = Console.ReadLine();
            
            int score = int.Parse(input[1]);
            foreach(char item in inputscore)
            {
                if (item == 'o')
                    score++;
                else if (item == 'x')
                    if (score > 0)
                        score--;
            }
            Console.WriteLine(score);
            Console.ReadKey();
        }
    }
}
