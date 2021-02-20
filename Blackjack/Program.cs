using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] InputString = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < InputString.Length; i++)
            {
                sum += int.Parse(InputString[i]);
            }
            if (sum >= 22)
            {
                Console.Write("bust");
            }
            else
            {
                Console.Write("win");
            }
        }
    }
}
