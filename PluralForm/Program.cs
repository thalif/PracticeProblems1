using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralForm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int Len = input.Length;
            
            if(input[Len - 1] != 's')
            {
                input += 's';
                Console.WriteLine(input);
            }
            else if(input[Len - 1] ==  's')
            {
                input += "es";
                Console.WriteLine(input);
            }
        }
    }
}
