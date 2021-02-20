using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int nBalls = int.Parse(input[0]);
            int pBlueBalls = int.Parse(input[1]);
            int pRedBalls = int.Parse(input[2]);

            if(pBlueBalls + pRedBalls == nBalls)
                Console.WriteLine(pBlueBalls);
            else if(pBlueBalls + pRedBalls < nBalls)

        }
    }
}
