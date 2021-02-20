using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchievetheGoal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLineScores = Console.ReadLine().Split(' ');

            int NSubject = int.Parse(firstLine[0]);
            int MaxMark = int.Parse(firstLine[1]);
            int TargetAvg = int.Parse(firstLine[2]);

            int SumOfScore = 0;
            for (int i = 0; i < secondLineScores.Length; i++)
            {
                SumOfScore += int.Parse(secondLineScores[i]);
            }

            if(GetAvg(NSubject,SumOfScore + MaxMark) < TargetAvg )
                Console.WriteLine("-1");
            else if (GetAvg(NSubject, SumOfScore + MaxMark) > TargetAvg)
                Console.WriteLine("0");
            else
            {
                for (int j = 0; j < MaxMark; j++)
                {
                    if (GetAvg(NSubject, SumOfScore + j) == TargetAvg)
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
        }
        static int GetAvg(int Nsubject, int sum)
        {
            return (int)sum / Nsubject;
        }
    }
}
