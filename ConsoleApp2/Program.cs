using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dec1 = new User();
            dec1.Decision = true;
            while (dec1.Decision == true)
            {
                Console.WriteLine("Tere!\nMis te soovite teha?");
                Console.WriteLine("\nLuua uue konto (1)\nLogida sisse (2)");
                string decision = Console.ReadLine();
                int one = 1;
                if (decision == "1")
                {
                    one = 1;
                }
                if (decision == "2")
                {
                    one = 2;
                }
                if (decision != "1" && decision != "2")
                {
                    Console.WriteLine("Pole selline valik");
                }
                if (one == 1)
                {
                    Console.Clear();
                    Console.WriteLine("---REGISTER---\n\n");
                    Console.WriteLine("Mis on teie nimi?");
                    var user1 = new User();
                    user1.UserName = Console.ReadLine();

                    Console.WriteLine("Nüüd tehke endale parool: ");
                    user1.Psw = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    user1.Balance = 150;

                    user1.Register();
                    Console.WriteLine("Olete loonud endale konto!\n");
                }

                if (one == 2)
                {
                    Console.Clear();
                    Console.WriteLine("---LOGIN---\n\n");
                    var login1 = new LogIn();
                    Console.WriteLine("Palun sisestage enda nimi: ");
                    login1.LogName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Palun sisestage pass: ");
                    login1.LogPsw = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    login1.Login();
                }
            }
            Console.ReadLine();
        }
    }
}
