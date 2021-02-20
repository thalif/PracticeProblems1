using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMax
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            long res1 = long.Parse(input[0]) * long.Parse(input[2]);
            long res2 = long.Parse(input[1]) * long.Parse(input[3]);
            long res3 = long.Parse(input[0]) * long.Parse(input[3]);
            long res4 = long.Parse(input[1]) * long.Parse(input[2]);

            Console.WriteLine(Math.Max(Math.Max(res1, res2), Math.Max(res3, res4)));
        }
    }
}
