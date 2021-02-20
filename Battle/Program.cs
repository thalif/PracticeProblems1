using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int Tak = int.Parse(input[0]) - int.Parse(input[1]);
            int Aok = int.Parse(input[2]) - int.Parse(input[3]);

            if (Tak > Aok)
                Console.WriteLine("Yes");
            else
            {
                if(Aok - Tak > Tak)
                    Console.WriteLine("No");
            }            
            Console.ReadKey();
        }
        static void CheckState()
        {

        }
    }
}
