using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Class
{
    class ConnectData
    {
        public SqlConnection Conn;
        public void Connect()
        {
            string StrCon = "";
            //string StrCon = @"Data Source=LAPTOP-T44JIQBS\SQLEXPRESS;Initial Catalog=quanlytruongtieuhocvip;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
            Conn.Open();
        }
        public void DisConnect()
        {
            Conn.Close();
            Conn.Dispose();
            Conn = null;
        }
        public Boolean exeSQL(string cmd)
        {
            try
            {
                SqlCommand Sc = new SqlCommand(cmd, Conn);
                Sc.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
