using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthogonality
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] aArray = Console.ReadLine().Split(' ');
            string[] bArray = Console.ReadLine().Split(' ');
            
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += int.Parse(aArray[i]) * int.Parse(bArray[i]);

            if (sum == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
