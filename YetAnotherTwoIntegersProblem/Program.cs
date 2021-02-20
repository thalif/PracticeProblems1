using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnotherTwoIntegersProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < Ninputs; i++)
            {
                int[] Numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                
                int Number1 = Math.Max(Numbers[0], Numbers[1]);
                int Number2 = Math.Min(Numbers[0], Numbers[1]);

                if (Number1 == Number2)
                    Console.WriteLine(0);
                else
                    for (int ithTime = 1; ithTime < (Number1 / 10) + 2; ithTime++)
                        if (Number2 + (10 * ithTime) >= Number1)
                        {
                            Console.WriteLine(ithTime);
                            break;
                        }
            }
        }
    }
}
