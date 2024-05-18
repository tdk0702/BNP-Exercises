namespace Chapter4
{
    partial class DownloadFile
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
            btnDownload = new Button();
            rtbContent = new RichTextBox();
            btnShow = new Button();
            tbxDesFile = new TextBox();
            SuspendLayout();
            // 
            // tbxUrl
            // 
            tbxUrl.Location = new Point(12, 12);
            tbxUrl.Name = "tbxUrl";
            tbxUrl.Size = new Size(256, 23);
            tbxUrl.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(274, 11);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(72, 23);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(12, 79);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(334, 287);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(274, 40);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(72, 23);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // tbxDesFile
            // 
            tbxDesFile.Location = new Point(12, 41);
            tbxDesFile.Name = "tbxDesFile";
            tbxDesFile.Size = new Size(256, 23);
            tbxDesFile.TabIndex = 4;
            // 
            // DownloadFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 378);
            Controls.Add(tbxDesFile);
            Controls.Add(btnShow);
            Controls.Add(rtbContent);
            Controls.Add(btnDownload);
            Controls.Add(tbxUrl);
            Name = "DownloadFile";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUrl;
        private Button btnDownload;
        private RichTextBox rtbContent;
        private Button btnShow;
        private TextBox tbxDesFile;
    }
}
