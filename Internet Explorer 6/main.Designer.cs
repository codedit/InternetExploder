//============================================================================
// Name			: main.Designer.cs
// Author		: codedit (codedit.me)
// Version		: 1.0
// Copyright	: Microsoft Corporation?
// Website		: http://github.com/codedit/InternetExploder 
// Description	: A webkit implementation of Internet Explorer
//============================================================================
namespace Internet_Explorer_6
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonBar = new System.Windows.Forms.ToolStrip();
            this.btn_back = new System.Windows.Forms.ToolStripSplitButton();
            this.btn_forward = new System.Windows.Forms.ToolStripSplitButton();
            this.btn_stop = new System.Windows.Forms.ToolStripButton();
            this.btn_refresh = new System.Windows.Forms.ToolStripButton();
            this.btn_home = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            this.btn_favs = new System.Windows.Forms.ToolStripButton();
            this.UrlBar = new System.Windows.Forms.ToolStrip();
            this.lbl_address = new System.Windows.Forms.ToolStripLabel();
            this.txt_url = new System.Windows.Forms.ToolStripTextBox();
            this.btn_go = new System.Windows.Forms.ToolStripButton();
            this.WinLogo = new System.Windows.Forms.PictureBox();
            this.BottomBar = new System.Windows.Forms.StatusStrip();
            this.lbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.WebView = new WebKit.WebKitBrowser();
            this.TopMenu.SuspendLayout();
            this.ButtonBar.SuspendLayout();
            this.UrlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinLogo)).BeginInit();
            this.BottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.favoritesToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TopMenu.Size = new System.Drawing.Size(641, 24);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "TopMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.favoritesToolStripMenuItem.Text = "F&avorites";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // ButtonBar
            // 
            this.ButtonBar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ButtonBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_back,
            this.btn_forward,
            this.btn_stop,
            this.btn_refresh,
            this.btn_home,
            this.toolStripSeparator1,
            this.btn_search,
            this.btn_favs});
            this.ButtonBar.Location = new System.Drawing.Point(0, 24);
            this.ButtonBar.Name = "ButtonBar";
            this.ButtonBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ButtonBar.Size = new System.Drawing.Size(641, 43);
            this.ButtonBar.TabIndex = 2;
            this.ButtonBar.Text = "ButtonBar";
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = false;
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 40);
            this.btn_back.Text = "Back";
            this.btn_back.ButtonClick += new System.EventHandler(this.btn_back_ButtonClick);
            // 
            // btn_forward
            // 
            this.btn_forward.AutoSize = false;
            this.btn_forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_forward.Enabled = false;
            this.btn_forward.Image = ((System.Drawing.Image)(resources.GetObject("btn_forward.Image")));
            this.btn_forward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(60, 40);
            this.btn_forward.ButtonClick += new System.EventHandler(this.btn_forward_ButtonClick);
            // 
            // btn_stop
            // 
            this.btn_stop.AutoSize = false;
            this.btn_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(40, 40);
            this.btn_stop.Text = "Stop";
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.AutoSize = false;
            this.btn_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(40, 40);
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_home
            // 
            this.btn_home.AutoSize = false;
            this.btn_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(40, 40);
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = false;
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 40);
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.toolStripSplitButton1_Click);
            // 
            // btn_favs
            // 
            this.btn_favs.AutoSize = false;
            this.btn_favs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_favs.Image = ((System.Drawing.Image)(resources.GetObject("btn_favs.Image")));
            this.btn_favs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_favs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_favs.Name = "btn_favs";
            this.btn_favs.Size = new System.Drawing.Size(90, 40);
            this.btn_favs.Text = "Favorites";
            this.btn_favs.Click += new System.EventHandler(this.btn_favs_Click);
            // 
            // UrlBar
            // 
            this.UrlBar.AutoSize = false;
            this.UrlBar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.UrlBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_address,
            this.txt_url,
            this.btn_go});
            this.UrlBar.Location = new System.Drawing.Point(0, 67);
            this.UrlBar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.UrlBar.Name = "UrlBar";
            this.UrlBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.UrlBar.Size = new System.Drawing.Size(641, 28);
            this.UrlBar.Stretch = true;
            this.UrlBar.TabIndex = 3;
            this.UrlBar.Text = "UrlBar";
            // 
            // lbl_address
            // 
            this.lbl_address.ForeColor = System.Drawing.Color.Gray;
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(50, 25);
            this.lbl_address.Text = "Address";
            // 
            // txt_url
            // 
            this.txt_url.AutoSize = false;
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(300, 23);
            this.txt_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_url_KeyPress);
            this.txt_url.Click += new System.EventHandler(this.txt_url_Click);
            // 
            // btn_go
            // 
            this.btn_go.Image = ((System.Drawing.Image)(resources.GetObject("btn_go.Image")));
            this.btn_go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_go.Name = "btn_go";
            this.btn_go.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_go.Size = new System.Drawing.Size(42, 25);
            this.btn_go.Text = "Go";
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // WinLogo
            // 
            this.WinLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WinLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WinLogo.BackgroundImage")));
            this.WinLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("WinLogo.InitialImage")));
            this.WinLogo.Location = new System.Drawing.Point(601, 0);
            this.WinLogo.Name = "WinLogo";
            this.WinLogo.Size = new System.Drawing.Size(40, 23);
            this.WinLogo.TabIndex = 6;
            this.WinLogo.TabStop = false;
            // 
            // BottomBar
            // 
            this.BottomBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status});
            this.BottomBar.Location = new System.Drawing.Point(0, 522);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(641, 22);
            this.BottomBar.TabIndex = 7;
            this.BottomBar.Text = "BotomBar";
            // 
            // lbl_status
            // 
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 17);
            this.lbl_status.Text = "Ready";
            // 
            // WebView
            // 
            this.WebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebView.BackColor = System.Drawing.Color.White;
            this.WebView.Location = new System.Drawing.Point(0, 92);
            this.WebView.Name = "WebView";
            this.WebView.Size = new System.Drawing.Size(641, 427);
            this.WebView.TabIndex = 4;
            this.WebView.Url = null;
            this.WebView.DocumentTitleChanged += new System.EventHandler(this.WebView_DocumentTitleChanged);
            this.WebView.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebView_Navigated);
            this.WebView.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebView_Navigating);
            this.WebView.Error += new WebKit.WebKitBrowserErrorEventHandler(this.WebView_Error);
            this.WebView.DownloadBegin += new WebKit.FileDownloadBeginEventHandler(this.WebView_DownloadBegin);
            this.WebView.CursorChanged += new System.EventHandler(this.WebView_CursorChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 544);
            this.Controls.Add(this.BottomBar);
            this.Controls.Add(this.WinLogo);
            this.Controls.Add(this.UrlBar);
            this.Controls.Add(this.WebView);
            this.Controls.Add(this.ButtonBar);
            this.Controls.Add(this.TopMenu);
            this.MainMenuStrip = this.TopMenu;
            this.Name = "main";
            this.ShowIcon = false;
            this.Text = "Internet Browser";
            this.Load += new System.EventHandler(this.main_Load);
            this.CursorChanged += new System.EventHandler(this.main_CursorChanged);
            this.MouseHover += new System.EventHandler(this.main_MouseHover);
            this.Resize += new System.EventHandler(this.main_Resize);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ButtonBar.ResumeLayout(false);
            this.ButtonBar.PerformLayout();
            this.UrlBar.ResumeLayout(false);
            this.UrlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinLogo)).EndInit();
            this.BottomBar.ResumeLayout(false);
            this.BottomBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ButtonBar;
        private System.Windows.Forms.ToolStripSplitButton btn_back;
        private System.Windows.Forms.ToolStripSplitButton btn_forward;
        private System.Windows.Forms.ToolStripButton btn_stop;
        private System.Windows.Forms.ToolStripButton btn_refresh;
        private System.Windows.Forms.ToolStripButton btn_home;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_search;
        private System.Windows.Forms.ToolStripButton btn_favs;
        private System.Windows.Forms.ToolStrip UrlBar;
        private System.Windows.Forms.ToolStripLabel lbl_address;
        private System.Windows.Forms.ToolStripButton btn_go;
        private WebKit.WebKitBrowser WebView;
        private System.Windows.Forms.ToolStripTextBox txt_url;
        private System.Windows.Forms.PictureBox WinLogo;
        private System.Windows.Forms.StatusStrip BottomBar;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status;
    }
}

