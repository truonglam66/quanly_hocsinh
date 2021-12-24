using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuanLyHocSinh.Classes
{
    public static class darkMode
    {
        public static Color dendam;
        public static Color trang;
        public static Color denlot;
        public static Color xanh;
        public static bool click = false;
        public static void TroCarMode()
        {
            if (click)
            {
                NewMethod();
            }
            else
            {
                trang = Color.Black;
                dendam = Color.FromArgb(191, 191, 191);
                denlot = Color.FromArgb(242, 242, 242);
                xanh = Color.FromArgb(0, 204, 204);

                click = true;
            }
        }

        private static void NewMethod()
        {
            trang = Color.White;
            dendam = Color.FromArgb(38, 38, 38);
            denlot = Color.FromArgb(51, 51, 51);
            xanh = Color.FromArgb(0, 204, 204); ;

            click = false;
        }
    }
}
