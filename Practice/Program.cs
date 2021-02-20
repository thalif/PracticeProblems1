using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] InputString = Console.ReadLine().Split(' ');

            int n = int.Parse(InputString[0]);
            int k = int.Parse(InputString[1]);
            int nValue = GetValue(n);
            int kValue = GetValue(k);
            if(nValue > kValue)
            {
                Console.WriteLine(nValue);
            }
            else
            {
                Console.WriteLine(kValue);
            }
            Console.ReadKey();
        }

        static int GetValue(int n)
        {
            string p = n.ToString();
            int toReturn = 0;
            for (int i = 0; i < p.Length; i++)
            {
                toReturn += int.Parse(p[i].ToString());
            }
            return toReturn;
        }
    }
}
