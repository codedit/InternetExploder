//============================================================================
// Name			: CrashView.cs
// Author		: codedit (codedit.me)
// Version		: 1.0
// Copyright	: Microsoft Coorporation?
// Website		: http://github.com/codedit/InternetExploder 
// Description	: A webkit implementation of Internet Explorer
//============================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Internet_Explorer_6
{
    public partial class CrashView : Form
    {
        public CrashView()
        {
            InitializeComponent();
        }

        private void btn_nosend_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //TODO
            this.Close();
        }
    }
}
