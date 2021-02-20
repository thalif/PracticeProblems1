using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> Alphabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string ch = Console.ReadLine();
            Console.WriteLine(Alphabet[Alphabet.IndexOf(ch[0]) + 1]);
        }
    }
}
