using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] Inputs = new string[N];
            for(int i = 0; i < N; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Inputs[i] = Console.ReadLine();
            }
            Result(Inputs);
        }
        static void Result(string[] Inputs)

        {
            for (int j = 0; j < Inputs.Length; j++)
            {
                string[] input = Inputs[j].Split(' ');
                List<int> row1 = new List<int>();

                for (int o = 0; o < input.Length; o++)
                {
                    row1.Add(int.Parse(input[o]));
                }
                row1.Sort();
                int AliceSum = 0;
                int BobSum = 0;

                for (int p = row1.Count; p > 0; p--)
                {
                    if (AliceSum == BobSum)
                    {
                        AliceSum += row1[p - 1];
                    }
                    else if (AliceSum > BobSum)
                    {
                        BobSum += row1[p - 1];
                    }
                    else if (AliceSum < BobSum)
                    {
                        AliceSum += row1[p - 1];
                    }
                }
                if (AliceSum == BobSum)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
