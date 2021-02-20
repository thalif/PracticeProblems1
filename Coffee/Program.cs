using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            if (input[2] ==  input[3] && input[4] ==  input[5])
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
