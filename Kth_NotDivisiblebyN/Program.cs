using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_NotDivisiblebyN
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < Ninputs; i++)
            {
                int[] inputNandK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int n = inputNandK[0];
                int k = inputNandK[1];

                int NotDivsCount = 0;
                int TheInteger = 0;
                while (NotDivsCount < k)
                {
                    TheInteger++;
                    if (TheInteger % n != 0)
                        NotDivsCount++;
                }
                Console.WriteLine(TheInteger);
            }
        }
    }
}
