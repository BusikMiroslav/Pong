﻿using System;
using System.Windows.Forms;

namespace Pong
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Main page with menu.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
        }
    }
}
