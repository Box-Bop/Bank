using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class LogIn : User
    {
        public string LogName { get; set; }
        public int LogPsw { get; set; }

        public void Login()
        {
            string fullPath = filePath + "\\" + LogName + ".txt";

            if (File.Exists(Directory.GetCurrentDirectory() + @"\" + LogName + ".txt"))
            {
                if (File.ReadAllLines(fullPath).Contains(Convert.ToString(LogPsw)))
                {
                    Console.WriteLine("Tere tulemast tagasi!\n");
                    string money = File.ReadLines(fullPath).Skip(1).Take(1).First();
                    Console.WriteLine("Teie kontos on: " + money + " euri.");

                    Console.WriteLine("Mis te soovite teha?\n\nMuuta oma konta summa (1)\nLogida välja (2)");
                    string answer = Console.ReadLine();
                    if (answer == "2")
                    {
                        Console.WriteLine("Olete välja logitud!");
                        Console.ReadLine();
                    }
                    if (answer == "1")
                    {
                        Console.WriteLine("Sisestage enda konto uue raha summa: ");
                        string newmon = Console.ReadLine();

                        string[] alllines = File.ReadAllLines(fullPath);
                        alllines[2 - 1] = newmon;
                        File.WriteAllLines(fullPath, alllines);
                        Console.Clear();
                        Console.WriteLine("Olete muutnud enda konto summma " + newmon + "'ks euroks!\n\nLoggime sind välja.\n\nKohtume uuesti!");
                    }
                }
            }
        }
    }
}
