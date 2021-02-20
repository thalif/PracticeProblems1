using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontBeLate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int D = int.Parse(inputs[0]);
            int T = int.Parse(inputs[1]);
            int S = int.Parse(inputs[2]);

            if((T*S) >= D)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
