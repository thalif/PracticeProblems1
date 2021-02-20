using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofRoundNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninputs = int.Parse(Console.ReadLine());

            for (int j = 0; j < Ninputs; j++)
            {
                string GivenNumber = Console.ReadLine();

                List<int> TermsFounded = new List<int>();
                for (int i = 0; i < GivenNumber.Length; i++)
                {
                    int NumberFrom = int.Parse(GivenNumber[i].ToString());
                    if (NumberFrom != 0)
                    {
                        int Number = (int)double.Parse(GivenNumber.Substring(i, GivenNumber.Length - i));
                        int DigitsOfNumber = (int)Math.Floor(Math.Log10(Number) == 0 ? 1 : Math.Pow(10, Math.Floor(Math.Log10(Number))));
                        TermsFounded.Add(NumberFrom * DigitsOfNumber);
                    }
                }

                Console.WriteLine(TermsFounded.Count());
                foreach (int item in TermsFounded)
                    Console.Write(item + " ");
            }
        }
    }
}
