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

                    bool decisionLoop = true;
                    while (decisionLoop == true)
                    {
                        Console.WriteLine("Mis te soovite teha?\n\nRaha välja võtta (1)\nLogida välja (2)");
                        string answer = Console.ReadLine();
                        if (answer == "2")
                        {
                            Console.WriteLine("Olete välja logitud!");
                            decisionLoop = false;
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        if (answer == "1")
                        {
                            Console.WriteLine("Sisestage summa, mis soovite väja võtta: ");
                            int withdraw = Convert.ToInt16(Console.ReadLine());

                            string[] alllines = File.ReadAllLines(fullPath);
                            int leftover = Convert.ToInt16(alllines[2 - 1]) - withdraw;
                            alllines[2 - 1] = Convert.ToString(leftover);
                            File.WriteAllLines(fullPath, alllines);
                            Console.Clear();
                            Console.WriteLine("Olete välja võtnud oma kontost: " + withdraw + " euri.\nTeie kontos on alles: " + leftover + " euri.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        if (answer != "1" && answer != "2")
                        {
                            Console.Clear();
                            Console.WriteLine(answer + " pole valikus, palun proovige uuesti.\n");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Vale parool\n");
                }
            }
            else
            {
                Console.WriteLine("Ei leidnud sellist konto omaniku\n");
            }
        }
    }
}
