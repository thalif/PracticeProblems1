using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twiblr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Input = Console.ReadLine().Split(' ');
            Console.WriteLine(((int.Parse(Input[0]) * 2)+100) -  int.Parse(Input[1]));
        }
    }
}
