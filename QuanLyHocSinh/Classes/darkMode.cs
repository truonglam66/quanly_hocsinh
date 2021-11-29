using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    class darkMode
    {
        public static Color dendam;
        public static Color trang;
        public static Color denlot;
        public static Color xanh;
        public static bool click = true;
        public static void TroCarMode()
        {
            if (click)
            {
                NewMethod();
            }
            else
            {
                trang = Color.Blue;
                dendam = Color.FromArgb(191, 191, 191);
                denlot = Color.White;
                xanh = Color.Blue;

                click = true;
            }
        }

        private static void NewMethod()
        {
            trang = Color.White;
            dendam = Color.FromArgb(38, 38, 38);
            denlot = Color.FromArgb(51, 51, 51);
            xanh = Color.FromArgb(38, 38, 38); ;

            click = false;
        }
    }
}
