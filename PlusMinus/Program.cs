using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int X = AB[0] - AB[1];
            int Y = AB[0] + X;
            Console.WriteLine(X +" "+ Y);
            Console.ReadKey();
        }
    }
}
