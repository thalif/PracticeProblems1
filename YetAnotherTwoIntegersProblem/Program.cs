using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnotherTwoIntegersProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] InputValues = new string[10];
            try
            {
                using (StreamReader sr = new StreamReader("E:/inputs.txt"))
                {
                    string line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        InputValues[i] = line;
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                
            }

            long N = int.Parse(InputValues[0]);

            for(long i = 1; i< N + 1; i++)
            {
                string[] input = InputValues[i].Split(' ');
                GetResult(long.Parse(input[0]), long.Parse(input[1]));
            }
        }

        static void GetResult(long from , long to)
        {
            long points = 1;
            int trackP = 0;
            long Move = 0;

            if(from == to)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (from < to)
                {
                    while (true)
                    {
                        if (from + points < to)
                        {
                            points++;
                            trackP++;
                            if (trackP == 10)
                            {
                                Move++;
                                trackP = 1;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine(Move);
                }
                else
                {
                    while (true)
                    {
                        if (from - points > to)
                        {
                            points++;
                            trackP++;
                            if (trackP == 10)
                            {
                                Move++;
                                trackP = 0;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    Move += 1;
                    Console.WriteLine(Move);
                }
            }
        }
    }
}
