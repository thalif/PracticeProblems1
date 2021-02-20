using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brick
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Input = Console.ReadLine().Split(' ');
            int Truck = int.Parse(Input[0]);
            int BrickW = int.Parse(Input[1]);

            int Weight = 0;
            int c = 0;
            while(true)
            {
                if(Weight + BrickW > Truck)
                {
                    break;
                }
                else
                {
                    Weight += BrickW;
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
