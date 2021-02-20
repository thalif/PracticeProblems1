using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonandLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace("{", string.Empty);
            input = input.Replace("}", string.Empty);
            string[] si = input.Split(',');
            string tempp = "";
            if(si[0] == "" && si[0] == "")
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < si.Length; i++)
                {
                    if (!tempp.Contains(si[i].Trim()))
                    {
                        tempp += si[i].Trim();
                    }
                }
                Console.WriteLine(tempp.Length);
            }
        }
    }
}
