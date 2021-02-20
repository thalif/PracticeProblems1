using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int c = 1;
            for(int i = 1; i < input; i++)
            {
                if (i % 2 == 0)
                    c++;
            }
            if(input%2 == 0)
                Console.WriteLine(c*c);
            else
                Console.WriteLine(c*(c-1));
        }
    }
}
