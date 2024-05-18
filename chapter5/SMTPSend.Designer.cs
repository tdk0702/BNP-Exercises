namespace Chapter5
{
    partial class SMTPSend
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
            tbxIp = new TextBox();
            tbxPort = new TextBox();
            tbxFrom = new TextBox();
            tbxTo = new TextBox();
            tbxSubject = new TextBox();
            tbxBody = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // tbxIp
            // 
            tbxIp.Location = new Point(12, 12);
            tbxIp.Name = "tbxIp";
            tbxIp.Size = new Size(128, 23);
            tbxIp.TabIndex = 0;
            // 
            // tbxPort
            // 
            tbxPort.Location = new Point(146, 12);
            tbxPort.Name = "tbxPort";
            tbxPort.Size = new Size(72, 23);
            tbxPort.TabIndex = 1;
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
            // tbxSubject
            // 
            tbxSubject.Location = new Point(12, 143);
            tbxSubject.Name = "tbxSubject";
            tbxSubject.Size = new Size(337, 23);
            tbxSubject.TabIndex = 4;
            // 
            // tbxBody
            // 
            tbxBody.Location = new Point(12, 172);
            tbxBody.Multiline = true;
            tbxBody.Name = "tbxBody";
            tbxBody.Size = new Size(337, 214);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 393);
            Controls.Add(btnSend);
            Controls.Add(tbxBody);
            Controls.Add(tbxSubject);
            Controls.Add(tbxTo);
            Controls.Add(tbxFrom);
            Controls.Add(tbxPort);
            Controls.Add(tbxIp);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxIp;
        private TextBox tbxPort;
        private TextBox tbxFrom;
        private TextBox tbxTo;
        private TextBox tbxSubject;
        private TextBox tbxBody;
        private Button btnSend;
    }
}
