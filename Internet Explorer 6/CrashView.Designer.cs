//============================================================================
// Name			: CrashView.Designer.cs
// Author		: codedit (codedit.me)
// Version		: 1.0
// Copyright	: Microsoft Coorporation?
// Website		: http://github.com/codedit/InternetExploder 
// Description	: A webkit implementation of Internet Explorer
//============================================================================
namespace Internet_Explorer_6
{
    partial class CrashView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrashView));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.WhitePane = new System.Windows.Forms.Panel();
            this.lbl_uhoh = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_infogone = new System.Windows.Forms.Label();
            this.lbl_sendreport = new System.Windows.Forms.Label();
            this.lbl_please = new System.Windows.Forms.Label();
            this.btn_nosend = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.WhitePane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WhitePane
            // 
            this.WhitePane.BackColor = System.Drawing.Color.White;
            this.WhitePane.Controls.Add(this.lbl_uhoh);
            this.WhitePane.Controls.Add(this.pictureBox1);
            this.WhitePane.Dock = System.Windows.Forms.DockStyle.Top;
            this.WhitePane.Location = new System.Drawing.Point(0, 0);
            this.WhitePane.Name = "WhitePane";
            this.WhitePane.Size = new System.Drawing.Size(435, 69);
            this.WhitePane.TabIndex = 0;
            // 
            // lbl_uhoh
            // 
            this.lbl_uhoh.AutoSize = true;
            this.lbl_uhoh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uhoh.Location = new System.Drawing.Point(12, 22);
            this.lbl_uhoh.Name = "lbl_uhoh";
            this.lbl_uhoh.Size = new System.Drawing.Size(322, 26);
            this.lbl_uhoh.TabIndex = 1;
            this.lbl_uhoh.Text = "Internet Explorer has encountered a problem and needs\nto close. We are so sorry f" +
    "or the inconvenience.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_infogone
            // 
            this.lbl_infogone.AutoSize = true;
            this.lbl_infogone.Location = new System.Drawing.Point(12, 89);
            this.lbl_infogone.Name = "lbl_infogone";
            this.lbl_infogone.Size = new System.Drawing.Size(384, 26);
            this.lbl_infogone.TabIndex = 1;
            this.lbl_infogone.Text = "If you were in the middle of something, then now the information you are working\n" +
    "on might be lost.";
            // 
            // lbl_sendreport
            // 
            this.lbl_sendreport.AutoSize = true;
            this.lbl_sendreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sendreport.Location = new System.Drawing.Point(12, 132);
            this.lbl_sendreport.Name = "lbl_sendreport";
            this.lbl_sendreport.Size = new System.Drawing.Size(294, 13);
            this.lbl_sendreport.TabIndex = 2;
            this.lbl_sendreport.Text = "Please tell codedit productions about this problem.";
            // 
            // lbl_please
            // 
            this.lbl_please.AutoSize = true;
            this.lbl_please.Location = new System.Drawing.Point(12, 149);
            this.lbl_please.Name = "lbl_please";
            this.lbl_please.Size = new System.Drawing.Size(350, 52);
            this.lbl_please.TabIndex = 3;
            this.lbl_please.Text = "We have created an error report that you can send us to help us improve\nInternet " +
    "Explorer. We will treat this report as confidential and anonymous.\n\nThis report " +
    "should not contain much personal data.";
            // 
            // btn_nosend
            // 
            this.btn_nosend.Location = new System.Drawing.Point(348, 221);
            this.btn_nosend.Name = "btn_nosend";
            this.btn_nosend.Size = new System.Drawing.Size(75, 23);
            this.btn_nosend.TabIndex = 4;
            this.btn_nosend.Text = "Don\'t Send";
            this.btn_nosend.UseVisualStyleBackColor = true;
            this.btn_nosend.Click += new System.EventHandler(this.btn_nosend_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(236, 221);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(106, 23);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send Error Report";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // CrashView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 256);
            this.ControlBox = false;
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_nosend);
            this.Controls.Add(this.lbl_please);
            this.Controls.Add(this.lbl_sendreport);
            this.Controls.Add(this.lbl_infogone);
            this.Controls.Add(this.WhitePane);
            this.Name = "CrashView";
            this.Text = "Internet Explorer";
            this.WhitePane.ResumeLayout(false);
            this.WhitePane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel WhitePane;
        private System.Windows.Forms.Label lbl_uhoh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_infogone;
        private System.Windows.Forms.Label lbl_sendreport;
        private System.Windows.Forms.Label lbl_please;
        private System.Windows.Forms.Button btn_nosend;
        private System.Windows.Forms.Button btn_send;
    }
}