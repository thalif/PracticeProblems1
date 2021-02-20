using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationandBus
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();

            if(Input[0] == Input[1] && Input[1] == Input[2])
            {
                Console.WriteLine("No");
            }
            else if(Input[0] != Input[1] || Input[0] != Input[2])
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
