using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Input = Console.ReadLine().Split(' ');
            string n = Input[1];

            if(Input[0] ==  Input [1] && Input[0] != Input[2])
                Console.WriteLine("Yes");
            else if(Input[0] == Input[2] && Input[0] != Input[1])
                Console.WriteLine("Yes");
            else if(Input[1] == Input[2] && Input[1] != Input[0])
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
