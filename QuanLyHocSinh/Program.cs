﻿using QuanLyHocSinh.Forms;
﻿using QuanLyHocSinh.Forms.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinh.Classes;

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
            darkMode.TroCarMode();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormManagerMenu());
        }
    }
}
