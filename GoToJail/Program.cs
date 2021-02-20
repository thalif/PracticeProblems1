using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToJail
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] diesRoll = new string[N];
            for(int i = 0; i < N; i++)
                diesRoll[i] = Console.ReadLine();

            int count = 0;
            for(int i = 0; i < N; i++)
            {
                string[] roll = diesRoll[i].Split(' ');

                if (int.Parse(roll[0]) == int.Parse(roll[1]))
                    count++;
                else
                    count = 0;

                if (count == 3)
                    break;
            }
            if(count == 3)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
