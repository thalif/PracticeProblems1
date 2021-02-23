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
            Dictionary<string, int> UsersDataBase = new Dictionary<string, int>();
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i< N; i++)
            {
                string UserName = Console.ReadLine();
                if(UsersDataBase.ContainsKey(UserName))
                {
                    UsersDataBase[UserName]++;
                    string NewUser = UserName + (UsersDataBase[UserName]);
                    UsersDataBase.Add(NewUser, 0);
                    Console.WriteLine(NewUser);
                }
                else
                {
                    UsersDataBase.Add(UserName, 0);
                    Console.WriteLine("OK");
                }
            }
        }
    }
}
