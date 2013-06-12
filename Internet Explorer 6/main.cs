//============================================================================
// Name			: main.cs
// Author		: codedit (codedit.me)
// Version		: 1.0
// Copyright	: Microsoft Corporation?
// Website		: http://github.com/codedit/InternetExploder 
// Description	: A webkit implementation of Internet Explorer
//============================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Internet_Explorer_6
{
    public partial class main : Form
    {
        private string HomePage = "http://codedit.me/";//TODO
        private string ResourcesFolder = "Static.Resources";
        private int CrashChance = 0; //CrashChance between 0 and 100 if >0 then browser will randomly crash
        public main()
        {
            InitializeComponent();
        }
        private void RandomCrash() {
            Random rand = new Random();
            if (rand.Next(0, 99)<CrashChance)
            {
                CrashBrowser();
            }
        }
        private void CrashBrowser()
        {
            //test crash scenario 
            int x = 0;
            int s = 5 / x;
            //we could also just throw an exception of course
        }
        private void Navigate(string url)
        {
            try {
            WebView.Navigate(url);
            WebView.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            RandomCrash();
         }
        private void FixTxtUrl()
        {
			//fixes the size of the url box to make it fill the full width
            //ugly auto size trick
            txt_url.Width = UrlBar.Width - btn_go.Width - lbl_address.Width - UrlBar.Margin.Left - UrlBar.Margin.Right - 5;
        }
        private void main_Resize(object sender, EventArgs e)
        {
            FixTxtUrl();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            Navigate(txt_url.Text);
        }

        private void WebView_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            txt_url.Text = e.Url.AbsoluteUri;
            lbl_status.Text = "Loading";
        }

        private void txt_url_Click(object sender, EventArgs e)
        {

        }

        private void txt_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Navigate(txt_url.Text);
            }
        }

        private void WebView_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.Text = WebView.DocumentTitle;
            if (WebView.CanGoForward) { btn_forward.Enabled = true;  } else { btn_forward.Enabled = false; }
            if (WebView.CanGoBack) { btn_back.Enabled = true; } else {btn_back.Enabled=false; }
            lbl_status.Text = "Ready";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            WebView.Refresh();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            WebView.Stop();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Navigate(HomePage);
        }

        private void btn_back_ButtonClick(object sender, EventArgs e)
        {
            WebView.GoBack();
            btn_forward.Enabled = true;
        }

        private void btn_forward_ButtonClick(object sender, EventArgs e)
        {
            WebView.GoForward();
        }

        private void WebView_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = WebView.DocumentTitle;
        }

        private void WebView_DownloadBegin(object sender, WebKit.FileDownloadBeginEventArgs e)
        {
           //TODO: add ie6 styled download dialog
           MessageBox.Show("Downloads are not supported yet");
        }

        private void main_Load(object sender, EventArgs e)
        {                
                FixTxtUrl();
                Navigate(HomePage);
           
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            Navigate("http://google.com");
        
        }

        private void btn_favs_Click(object sender, EventArgs e)
        {
            //TODO
            CrashBrowser();
        }

        private void main_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void WebView_CursorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("link");
        }

        private void main_CursorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("links");
        }

        private void WebView_Error(object sender, WebKit.WebKitBrowserErrorEventArgs e)
        {
            Navigate(("file:///"+Directory.GetCurrentDirectory()+"\\"+ResourcesFolder+"\\error.htm").Replace("\\","/").Replace(" ","%20"));
            txt_url.Text = "";
            //TODO: load error page in a nicer way using WebView.documentext perhaps and implement e.Description in to page
        }
    }
}
