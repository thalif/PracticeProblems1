using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinorChange
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            int toChange = 0;
            for (int i = 0; i < string1.Length; i++)
                if (string1[i] != string2[i])
                    toChange++;
            Console.WriteLine(toChange);
        }
    }
}
