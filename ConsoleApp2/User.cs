using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    public class User
    {
        public string Psw { get; set; }
        public int Balance { get; set; }
        public string UserName { get; set; }
        public string filePath = Directory.GetCurrentDirectory();

        public void LoggedIn()
        {
            File.Create(filePath + UserName + ".txt");
            using (StreamWriter sw = File.CreateText(Path.Combine(filePath + UserName + ".txt")))
            {
                sw.WriteLine(Psw);
            }
        }
    }
}
