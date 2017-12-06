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
        public int Psw { get; set; }
        public int Balance { get; set; }
        public string UserName { get; set; }
        public string filePath = Directory.GetCurrentDirectory();

        public void LoggedIn()
        {

            string fullPath = filePath + "\\" + UserName;
            File.Create(filePath + UserName + ".txt");

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fullPath, true))
                {
                    file.WriteLine(Psw);
                    file.WriteLine(Balance);
                }
        } 
    }
}
