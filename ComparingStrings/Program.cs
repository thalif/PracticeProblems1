using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            if(a > b)
                for (int i = 0; i < a; i++)
                    Console.Write(b);
            else
                for (int i = 0; i < b; i++)
                    Console.Write(a);
        }
    }
}
