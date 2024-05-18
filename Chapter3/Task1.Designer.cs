namespace Chapter3
{
    partial class Task1
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
            tbxSend = new TextBox();
            lbxSend = new ListBox();
            btnConnect = new Button();
            btnSend = new Button();
            tbxLocalPort = new TextBox();
            tbxIpAdd = new TextBox();
            tbxPort = new TextBox();
            lbxReceive = new ListBox();
            btnNewForm = new Button();
            SuspendLayout();
            // 
            // tbxSend
            // 
            tbxSend.Location = new Point(12, 12);
            tbxSend.Name = "tbxSend";
            tbxSend.Size = new Size(400, 23);
            tbxSend.TabIndex = 0;
            // 
            // lbxSend
            // 
            lbxSend.FormattingEnabled = true;
            lbxSend.ItemHeight = 15;
            lbxSend.Location = new Point(12, 41);
            lbxSend.Name = "lbxSend";
            lbxSend.Size = new Size(400, 139);
            lbxSend.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(533, 31);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Kết nối";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(418, 12);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 3;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbxLocalPort
            // 
            tbxLocalPort.Location = new Point(510, 60);
            tbxLocalPort.Name = "tbxLocalPort";
            tbxLocalPort.Size = new Size(98, 23);
            tbxLocalPort.TabIndex = 4;
            // 
            // tbxIpAdd
            // 
            tbxIpAdd.Location = new Point(510, 112);
            tbxIpAdd.Name = "tbxIpAdd";
            tbxIpAdd.Size = new Size(98, 23);
            tbxIpAdd.TabIndex = 5;
            // 
            // tbxPort
            // 
            tbxPort.Location = new Point(510, 141);
            tbxPort.Name = "tbxPort";
            tbxPort.Size = new Size(98, 23);
            tbxPort.TabIndex = 6;
            // 
            // lbxReceive
            // 
            lbxReceive.FormattingEnabled = true;
            lbxReceive.ItemHeight = 15;
            lbxReceive.Location = new Point(12, 186);
            lbxReceive.Name = "lbxReceive";
            lbxReceive.Size = new Size(610, 154);
            lbxReceive.TabIndex = 7;
            // 
            // btnNewForm
            // 
            btnNewForm.Location = new Point(418, 141);
            btnNewForm.Name = "btnNewForm";
            btnNewForm.Size = new Size(86, 23);
            btnNewForm.TabIndex = 8;
            btnNewForm.Text = "Thêm Form";
            btnNewForm.UseVisualStyleBackColor = true;
            btnNewForm.Click += btnNewForm_Click;
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 353);
            Controls.Add(btnNewForm);
            Controls.Add(lbxReceive);
            Controls.Add(tbxPort);
            Controls.Add(tbxIpAdd);
            Controls.Add(tbxLocalPort);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(lbxSend);
            Controls.Add(tbxSend);
            Name = "Task1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxSend;
        private ListBox lbxSend;
        private Button btnConnect;
        private Button btnSend;
        private TextBox tbxLocalPort;
        private TextBox tbxIpAdd;
        private TextBox tbxPort;
        private ListBox lbxReceive;
        private Button btnNewForm;
    }
}
