using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceBobandCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < Ninputs; i++)
            {
                int NCandies = int.Parse(Console.ReadLine());;
                int[] CandyBox = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();;
                StartGame(CandyBox, NCandies);
            }
        }
        static void StartGame(int[] CandyBox,int NCandies)
        {
            int AliceMove = 0;
            int BobMove = NCandies - 1;

            int AliceCandiesSum = 0;
            int BobCandiesSum = 0;
            int AliceTaken = AliceCandiesSum;
            int BobTaken = BobCandiesSum;

            int Moves = 0;
            while (true)
            {
                while (true)
                {
                    AliceTaken += CandyBox[AliceMove];
                    AliceMove++;
                    if ((AliceMove - 1) == BobMove)
                    {
                        Moves++;
                        AliceCandiesSum += AliceTaken;
                        Console.WriteLine(Moves + " " + (AliceCandiesSum) + " " + (BobCandiesSum));
                        return;
                    }
                    else
                        if (AliceTaken > BobTaken)
                        {
                            Moves++;
                            AliceCandiesSum += AliceTaken;
                            BobTaken = 0;
                            break;
                        }
                }
                while (true)
                {
                    BobTaken += CandyBox[BobMove];
                    BobMove--;
                    if ((AliceMove - 1) == BobMove)
                    {
                        Moves++;
                        BobCandiesSum += BobTaken;
                        Console.WriteLine(Moves + " " + (AliceCandiesSum) + " " + (BobCandiesSum));
                        return;
                    }
                    else
                        if (BobTaken > AliceTaken)
                        {
                            Moves++;
                            BobCandiesSum += BobTaken;
                            AliceTaken = 0;
                            break;
                        }
                }
            }
        }
    }
}
