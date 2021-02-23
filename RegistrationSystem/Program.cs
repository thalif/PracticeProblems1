using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> UserNameDataBase = new List<string>();

            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                string UserName = Console.ReadLine();
                if (UserNameDataBase.Contains(UserName))
                {
                    int k = 1;
                    while (UserNameDataBase.Contains(UserName + k))
                    {
                        k++;
                    }
                    UserNameDataBase.Add(UserName + k);
                    Console.WriteLine(UserName + k);
                }
                else
                {
                    UserNameDataBase.Add(UserName);
                    Console.WriteLine("OK");
                }
            }
        }
    }
}
