namespace Chapter2
{
    partial class TextStream
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
            tbResults = new TextBox();
            openFileDialog = new OpenFileDialog();
            btnReadSync = new Button();
            btnReadAsync = new Button();
            SuspendLayout();
            // 
            // tbResults
            // 
            tbResults.Dock = DockStyle.Top;
            tbResults.Location = new Point(0, 0);
            tbResults.Multiline = true;
            tbResults.Name = "tbResults";
            tbResults.Size = new Size(407, 175);
            tbResults.TabIndex = 3;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // btnReadSync
            // 
            btnReadSync.AutoSize = true;
            btnReadSync.Dock = DockStyle.Top;
            btnReadSync.Location = new Point(0, 200);
            btnReadSync.Name = "btnReadSync";
            btnReadSync.Size = new Size(407, 25);
            btnReadSync.TabIndex = 7;
            btnReadSync.Text = "Read Sync";
            btnReadSync.UseVisualStyleBackColor = true;
            // 
            // btnReadAsync
            // 
            btnReadAsync.AutoSize = true;
            btnReadAsync.Dock = DockStyle.Top;
            btnReadAsync.Location = new Point(0, 175);
            btnReadAsync.Name = "btnReadAsync";
            btnReadAsync.Size = new Size(407, 25);
            btnReadAsync.TabIndex = 6;
            btnReadAsync.Text = "Read Async";
            btnReadAsync.UseVisualStyleBackColor = true;
            // 
            // TextStream
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 240);
            Controls.Add(btnReadSync);
            Controls.Add(btnReadAsync);
            Controls.Add(tbResults);
            Name = "TextStream";
            Text = "TextStream";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbResults;
        private OpenFileDialog openFileDialog;
        private Button btnReadSync;
        private Button btnReadAsync;
    }
}