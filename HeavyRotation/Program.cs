using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n == 1)
                Console.WriteLine("Black");
            else if( n % 2 == 0)
                Console.WriteLine("White");
            else if( n%2 != 0)
                Console.WriteLine("Black");
        }
    }
}
