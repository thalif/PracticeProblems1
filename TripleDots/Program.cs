using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleDots
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();

            if(word.Length == k)
                Console.WriteLine(word);
            else if(word.Length > k)
                Console.WriteLine(word.Substring(0,k)+"...");
            else if(word.Length < k)
                Console.WriteLine(word);
        }
    }
}
