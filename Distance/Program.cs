using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int T = int.Parse(input[1]);

            string[] points = new string[n];

            try
            {
                using (StreamReader sr = new StreamReader("E:/inputs.txt"))
                {
                    string line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        points[i] = line;
                        i++;
                    }
                }
            }
            catch (Exception e)
            {

            }
            int c = 0;

            for(int i = 0; i < n; i++)
            {
                string[] p = points[i].Split(' ');
                if (Math.Sqrt(Math.Pow(double.Parse(p[0]), 2) + Math.Pow(double.Parse(p[1]), 2)) >= T)
                    c++;
                    
            }
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
