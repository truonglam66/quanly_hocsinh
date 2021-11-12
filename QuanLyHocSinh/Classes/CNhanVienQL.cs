using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    class CNhanVienQL
    {
        string username;
        string password;

        public CNhanVienQL()
        {
            username = "user";
            password = "user";
        }

        public CNhanVienQL(string _username, string _password)
        {
            username = _username;
            password = _password;
        }

        public string GetUserName()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetUserName(string _username)
        {
            this.username = _username;
        }

        public void SetPassword(string _password)
        {
            this.password = _password;
        }
    }
}
