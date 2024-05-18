namespace Chapter5
{
    partial class POP3Delete
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
            btnDo = new Button();
            tbxPass = new TextBox();
            tbxUser = new TextBox();
            tbxServer = new TextBox();
            lstLogs = new ListBox();
            SuspendLayout();
            // 
            // btnDo
            // 
            btnDo.Location = new Point(284, 112);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(70, 23);
            btnDo.TabIndex = 13;
            btnDo.Text = "Do it";
            btnDo.UseVisualStyleBackColor = true;
            btnDo.Click += btnDo_Click;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(17, 68);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(206, 23);
            tbxPass.TabIndex = 10;
            // 
            // tbxUser
            // 
            tbxUser.Location = new Point(17, 39);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(206, 23);
            tbxUser.TabIndex = 9;
            // 
            // tbxServer
            // 
            tbxServer.Location = new Point(17, 10);
            tbxServer.Name = "tbxServer";
            tbxServer.Size = new Size(206, 23);
            tbxServer.TabIndex = 7;
            // 
            // lstLogs
            // 
            lstLogs.FormattingEnabled = true;
            lstLogs.ItemHeight = 15;
            lstLogs.Location = new Point(12, 141);
            lstLogs.Name = "lstLogs";
            lstLogs.Size = new Size(342, 229);
            lstLogs.TabIndex = 14;
            // 
            // POP3Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 395);
            Controls.Add(lstLogs);
            Controls.Add(btnDo);
            Controls.Add(tbxPass);
            Controls.Add(tbxUser);
            Controls.Add(tbxServer);
            KeyPreview = true;
            Name = "POP3Delete";
            Text = "POP3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDo;
        private TextBox tbxTo;
        private TextBox tbxPass;
        private TextBox tbxUser;
        private TextBox tbxServer;
        private ListBox lstLogs;
    }
}