﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstproject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            //Application.Run(new loginform());
            //Application.Run(new borrowbook());
            //Application.Run(new AdminForm());
            //Application.Run(new AddBookInfo());
            //Application.Run(new AddMemberInfo());
            Application.Run(new ShowStaff());
            //Application.Run(new ShowUsers());

        }
    }
}
