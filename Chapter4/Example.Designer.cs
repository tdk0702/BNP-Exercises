﻿namespace Chapter4
{
    partial class Example
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxUrl = new TextBox();
            btnCapture = new Button();
            rtbGet = new RichTextBox();
            SuspendLayout();
            // 
            // tbxUrl
            // 
            tbxUrl.Location = new Point(12, 12);
            tbxUrl.Name = "tbxUrl";
            tbxUrl.Size = new Size(256, 23);
            tbxUrl.TabIndex = 0;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(274, 11);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(72, 23);
            btnCapture.TabIndex = 1;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += this.btnCapture_Click;
            // 
            // rtbGet
            // 
            rtbGet.Location = new Point(12, 41);
            rtbGet.Name = "rtbGet";
            rtbGet.Size = new Size(334, 325);
            rtbGet.TabIndex = 2;
            rtbGet.Text = "";
            // 
            // Example
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 378);
            Controls.Add(rtbGet);
            Controls.Add(btnCapture);
            Controls.Add(tbxUrl);
            Name = "Example";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUrl;
        private Button btnCapture;
        private RichTextBox rtbGet;
    }
}