<<<<<<< HEAD
﻿using QuanLyHocSinh.Forms;
=======
﻿using QuanLyHocSinh.Forms.Manager;
>>>>>>> origin/hoangtruong
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using QuanLyHocSinh.Classes;
=======

>>>>>>> origin/hoangtruong
namespace QuanLyHocSinh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
<<<<<<< HEAD
            darkMode.TroCarMode();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormManagerMenu());
=======
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDKNhapHoc());
>>>>>>> origin/hoangtruong
        }
    }
}
