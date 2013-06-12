//============================================================================
// Name			: Program.cs
// Author		: codedit (codedit.me)
// Version		: 1.0
// Copyright	: Microsoft Corporation?
// Website		: http://github.com/codedit/InternetExploder 
// Description	: A webkit implementation of Internet Explorer
//============================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Internet_Explorer_6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new main());
            }
            catch (Exception e) {
                //Application.Run(new CrashView());
                CrashView crasher = new CrashView();
                crasher.ShowDialog();
            
            }
        }
    }
}
