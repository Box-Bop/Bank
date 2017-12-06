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
            string fullPath = filePath + "\\" + UserName;
            File.OpenRead (fullPath);
            File.
        }

    }
}
