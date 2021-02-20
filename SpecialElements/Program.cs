using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < Ninputs; i++)
            {
                int NArrayElements = int.Parse(Console.ReadLine());
                int[] GivenArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int Founded = FindElement(GivenArray);
                if (Founded == 0)
                {
                    GivenArray = GivenArray.Reverse().ToArray();
                    Founded = FindElement(GivenArray);
                }
                Console.WriteLine(Founded);
            }
        }
        static int FindElement(int[] givenArray)
        {
            int found = 0;
            for (int i = 2; i < givenArray.Length; i++)
                if (PowerUpCombination(SliceArray(givenArray, 0, i - 1)).Contains(givenArray[i]))
                    found++;
            return found;
        }
        static List<int> PowerUpCombination(int[] givenArray)
        {
            List<int> FinalPowerCombination = new List<int>();
            for(int i = 0; i < givenArray.Length - 1; i++)
            {
                int[] leftSlice = SliceArray(givenArray, i, givenArray.Length - 1);
                FinalPowerCombination.AddRange(SumCombinations(leftSlice));
            }
            return FinalPowerCombination.Distinct().ToList();
        }

        static List<int> SumCombinations(int[] ArrayPart)
        {
            List<int> SumCombinations = new List<int>();
            for (int i = 0; i < ArrayPart.Length; i++)
                if (ArrayPart.Length - i >= 2)
                    SumCombinations.Add(SliceArray(ArrayPart, 0, ArrayPart.Length - (i + 1)).Sum());
            return SumCombinations;
        }

        static int[] SliceArray(int[] givenArray, int start, int end)
        {
            int SlicedLength = (end - start) + 1;
            int[] SlicedArray = new int[SlicedLength];

            for (int i = 0; i < SlicedLength; i++)
                SlicedArray[i] = givenArray[start++];

            return SlicedArray;
        }
    }
}
