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
            Console.WriteLine("Tere!\nMis te soovite teha?");
            Console.WriteLine("\nLuua uue konto (1)\nLogida sisse (2)");
            string decision = Console.ReadLine();

            if (decision == "1")
            {
                Console.WriteLine("Mis on teie nimi?");
                var user1 = new User();
                user1.UserName = Console.ReadLine();
                Console.WriteLine("Tore!\nNüüd tehke endale parool: ");
                user1.Psw = Convert.ToString(Console.ReadLine());
                user1.LoggedIn();
            }

            Console.ReadLine();
        }
    }
}
