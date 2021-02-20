using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RemoveIt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] InputValues = new string[2];
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

            string[] Row1 = InputValues[0].Split();
            string Sequence = InputValues[1];

            string Ninputs = Row1[0];
            char Remove = char.Parse( Row1[1]);

            string temp = "";
            foreach(char c in Sequence)
            {
                if(c != Remove && c != ' ')
                    temp += c + " ";
            }
            Console.WriteLine(temp.Trim());
            Console.ReadKey();
        }
    }
}
