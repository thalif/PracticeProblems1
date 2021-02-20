using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoringApartments
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninputs = int.Parse(Console.ReadLine());

            int[] input = new int[Ninputs];
            for (int i = 0; i < Ninputs; i++)
                input[i] = int.Parse(Console.ReadLine());

            foreach (int key in input)
                Borred(key);
        }
        static void Borred(int Key)
        {
            int KeyAt = Key % 10;

            int KeyDigits = Math.Ceiling(Math.Log10(Key)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling(Math.Log10(Key)));
            int keyPressedCount = KeyAt * 10;

            if (KeyDigits == 1)
                keyPressedCount -= 9;
            else if (KeyDigits == 2)
                keyPressedCount -= 7;
            else if (KeyDigits == 3)
                keyPressedCount -= 4;

            Console.WriteLine(keyPressedCount);
        }
    }
}
