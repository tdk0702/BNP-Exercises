namespace Chapter5
{
    partial class POP3
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
            btnEnd = new Button();
            tbxBody = new TextBox();
            tbxPass = new TextBox();
            tbxUser = new TextBox();
            tbxServer = new TextBox();
            btnConnect = new Button();
            btnLogin = new Button();
            btnGet = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(311, 112);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(43, 23);
            btnEnd.TabIndex = 13;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // tbxBody
            // 
            tbxBody.Location = new Point(17, 141);
            tbxBody.Multiline = true;
            tbxBody.Name = "tbxBody";
            tbxBody.Size = new Size(337, 243);
            tbxBody.TabIndex = 12;
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
            // btnConnect
            // 
            btnConnect.Location = new Point(17, 112);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(65, 23);
            btnConnect.TabIndex = 14;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(106, 112);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(52, 23);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(179, 112);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(44, 23);
            btnGet.TabIndex = 16;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(247, 112);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(43, 23);
            btnQuit.TabIndex = 17;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // POP3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 395);
            Controls.Add(btnQuit);
            Controls.Add(btnGet);
            Controls.Add(btnLogin);
            Controls.Add(btnConnect);
            Controls.Add(btnEnd);
            Controls.Add(tbxBody);
            Controls.Add(tbxPass);
            Controls.Add(tbxUser);
            Controls.Add(tbxServer);
            KeyPreview = true;
            Name = "POP3";
            Text = "POP3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnd;
        private TextBox tbxBody;
        private TextBox tbxTo;
        private TextBox tbxPass;
        private TextBox tbxUser;
        private TextBox tbxServer;
        private Button btnConnect;
        private Button btnLogin;
        private Button btnGet;
        private Button btnQuit;
    }
}