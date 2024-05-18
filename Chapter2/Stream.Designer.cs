namespace Chapter2
{
    partial class Stream
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
            tbResults = new TextBox();
            openFileDialog = new OpenFileDialog();
            btnReadAsync = new Button();
            btnReadSync = new Button();
            SuspendLayout();
            // 
            // tbResults
            // 
            tbResults.Dock = DockStyle.Top;
            tbResults.Location = new Point(5, 5);
            tbResults.Multiline = true;
            tbResults.Name = "tbResults";
            tbResults.Size = new Size(395, 175);
            tbResults.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // btnReadAsync
            // 
            btnReadAsync.AutoSize = true;
            btnReadAsync.Dock = DockStyle.Top;
            btnReadAsync.Location = new Point(5, 180);
            btnReadAsync.Name = "btnReadAsync";
            btnReadAsync.Size = new Size(395, 25);
            btnReadAsync.TabIndex = 1;
            btnReadAsync.Text = "Read Async";
            btnReadAsync.UseVisualStyleBackColor = true;
            btnReadAsync.Click += btnReadAsync_Click;
            // 
            // btnReadSync
            // 
            btnReadSync.AutoSize = true;
            btnReadSync.Dock = DockStyle.Top;
            btnReadSync.Location = new Point(5, 205);
            btnReadSync.Name = "btnReadSync";
            btnReadSync.Size = new Size(395, 25);
            btnReadSync.TabIndex = 2;
            btnReadSync.Text = "Read Sync";
            btnReadSync.UseVisualStyleBackColor = true;
            btnReadSync.Click += btnReadSync_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 243);
            Controls.Add(btnReadSync);
            Controls.Add(btnReadAsync);
            Controls.Add(tbResults);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbResults;
        private OpenFileDialog openFileDialog;
        private Button btnReadAsync;
        private Button btnReadSync;
    }
}
