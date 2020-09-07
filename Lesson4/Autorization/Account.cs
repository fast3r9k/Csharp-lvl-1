using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorization
{
    public struct Account
    {
        public string login;
        public string password;

         public void LoadFromTxt(string filename)
        {
            filename = @"..\..\" + filename;
            StreamReader sr = new StreamReader(filename);
            login = sr.ReadLine();
            password = sr.ReadLine();
            sr.Close();
        }
    }
}
