using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapersPlease
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumbersCount = Console.ReadLine();

            string[] number = Console.ReadLine().Split(' ');
            int[] series = new int[int.Parse(NumbersCount)];

            bool result = true;
            for(int i = 0; i < int.Parse(NumbersCount); i++)
            {
                if(int.Parse(number[i]) % 2 == 0)
                {
                    if ((int.Parse(number[i]) % 3) == 0 || (int.Parse(number[i]) % 5) == 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }

            if(result)
            {
                Console.WriteLine("APPROVED");
            }   
            else
            {
                Console.WriteLine("DENIED");
            }   
        }
    }
}
