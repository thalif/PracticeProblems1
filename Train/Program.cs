using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int ii = int.Parse(input[1]);

            int res = Math.Max(N, ii) - Math.Min(N, ii);
            Console.WriteLine(res+1);
        }
    }
}
