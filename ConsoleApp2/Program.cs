﻿using System;
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

                Console.WriteLine("Nüüd tehke endale parool: ");
                user1.Psw = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                user1.Balance = 100;

                user1.Register();
                Console.WriteLine("Olete loonud endale konto!\n");
            }

            var login1 = new LogIn();
            Console.WriteLine("Palun sisestage enda nimi: ");
            login1.LogName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Palun sisestage pass: ");
            login1.LogPsw = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            login1.Login();
         
            Console.ReadLine();
        }
    }
}
