using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice1 = int.Parse(Console.ReadLine());
            int choice2 = int.Parse(Console.ReadLine());

            if(choice1 == 1 || choice1 == 2)
                if(choice2 == 2 || choice2 == 1)
                    Console.WriteLine("3");
            if(choice1 == 2 || choice1 == 3)
                if(choice2 == 3 || choice2 == 2)
                    Console.WriteLine("1");
            if(choice1 == 1 || choice1 == 3)
                if(choice2 == 3 || choice2 == 1)
                    Console.WriteLine("2");
        }
    }
}
