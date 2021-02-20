using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxAndSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            bool bend = true;
            for(int i = 1; i < n+1; i++)
            {
                if (i % 2 == 0)
                {
                    string s = DoString('.', m);
                    s = StuffString(bend, m);
                    bend = !bend;
                    Console.WriteLine(s);
                }
                else
                    Console.WriteLine(DoString('#', m));
            }
        }
        static string DoString(char c, int m)
        {
            string toReturn = string.Empty;
            for (int i = 0; i < m; i++)
                toReturn += c;
            return toReturn;
        }
        static string StuffString(bool b,int m)
        {
            string s = string.Empty;
            if (b)
            {

                for (int i = 0; i < m - 1; i++)
                    s += '.';
                s = s.Substring(0, s.Length) + '#';
            }
            else
            {
                s += '#';
                for (int i = 0; i < m - 1; i++)
                    s += '.';
            }
            return s;
        }
    }
}
