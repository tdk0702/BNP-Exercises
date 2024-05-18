namespace Chapter5
{
    partial class Mail
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
            tbxServer = new TextBox();
            tbxFrom = new TextBox();
            tbxTo = new TextBox();
            tbxBody = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // tbxServer
            // 
            tbxServer.Location = new Point(12, 12);
            tbxServer.Name = "tbxServer";
            tbxServer.Size = new Size(206, 23);
            tbxServer.TabIndex = 0;
            // 
            // tbxFrom
            // 
            tbxFrom.Location = new Point(12, 41);
            tbxFrom.Name = "tbxFrom";
            tbxFrom.Size = new Size(206, 23);
            tbxFrom.TabIndex = 2;
            // 
            // tbxTo
            // 
            tbxTo.Location = new Point(12, 70);
            tbxTo.Name = "tbxTo";
            tbxTo.Size = new Size(206, 23);
            tbxTo.TabIndex = 3;
            // 
            // tbxBody
            // 
            tbxBody.Location = new Point(12, 143);
            tbxBody.Multiline = true;
            tbxBody.Name = "tbxBody";
            tbxBody.Size = new Size(337, 243);
            tbxBody.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(274, 114);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 6;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Mail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 393);
            Controls.Add(btnSend);
            Controls.Add(tbxBody);
            Controls.Add(tbxTo);
            Controls.Add(tbxFrom);
            Controls.Add(tbxServer);
            Name = "Mail";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxServer;
        private TextBox tbxFrom;
        private TextBox tbxTo;
        private TextBox tbxBody;
        private Button btnSend;
    }
}
