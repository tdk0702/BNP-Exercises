﻿namespace Chapter3.TCPChat
{
    partial class TCPServer
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
            tbxIp = new TextBox();
            btnConnect = new Button();
            lbxListen = new ListBox();
            SuspendLayout();
            // 
            // tbxIp
            // 
            tbxIp.Location = new Point(12, 12);
            tbxIp.Name = "tbxIp";
            tbxIp.Size = new Size(281, 23);
            tbxIp.TabIndex = 0;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(299, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(86, 23);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Listen";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // lbxListen
            // 
            lbxListen.FormattingEnabled = true;
            lbxListen.ItemHeight = 15;
            lbxListen.Location = new Point(12, 41);
            lbxListen.Name = "lbxListen";
            lbxListen.Size = new Size(368, 334);
            lbxListen.TabIndex = 2;
            // 
            // TCPServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 390);
            Controls.Add(lbxListen);
            Controls.Add(btnConnect);
            Controls.Add(tbxIp);
            Name = "TCPServer";
            Text = "TCPChat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxIp;
        private Button btnConnect;
        private ListBox lbxListen;
    }
}