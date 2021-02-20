using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JudgeStatusSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            string[] InputValues = new string[n];
            
            for(int k = 0; k < n; k++)
            {
                InputValues[k] = Console.ReadLine();
            }
            int ac = 0;
            int wa = 0;
            int tle = 0;
            int re = 0;

            for(int i = 0; i < n; i++)
            {
                if (InputValues[i] == "AC")
                    ac++;
                else if (InputValues[i] == "WA")
                    wa++;
                else if (InputValues[i] == "TLE")
                    tle++;
                else if (InputValues[i] == "RE")
                    re++;
            }

            Console.WriteLine("AC x "+ac);
            Console.WriteLine("WA x "+wa);
            Console.WriteLine("TLE x "+tle);
            Console.WriteLine("RE x "+re);
        }
    }
}
