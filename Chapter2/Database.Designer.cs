namespace Chapter2
{
    partial class Database
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
            txtTenSerVer = new TextBox();
            btnSqlConnect = new Button();
            btnOleConnect = new Button();
            tbxOleCon = new TextBox();
            btnQuery = new Button();
            tbxQuery = new TextBox();
            tbxResult = new TextBox();
            SuspendLayout();
            // 
            // txtTenSerVer
            // 
            txtTenSerVer.Location = new Point(12, 12);
            txtTenSerVer.Name = "txtTenSerVer";
            txtTenSerVer.Size = new Size(100, 23);
            txtTenSerVer.TabIndex = 0;
            // 
            // btnSqlConnect
            // 
            btnSqlConnect.Location = new Point(118, 11);
            btnSqlConnect.Name = "btnSqlConnect";
            btnSqlConnect.Size = new Size(85, 23);
            btnSqlConnect.TabIndex = 1;
            btnSqlConnect.Text = "SQL Connect";
            btnSqlConnect.UseVisualStyleBackColor = true;
            btnSqlConnect.Click += btnSqlConnect_Click;
            // 
            // btnOleConnect
            // 
            btnOleConnect.Location = new Point(118, 40);
            btnOleConnect.Name = "btnOleConnect";
            btnOleConnect.Size = new Size(85, 23);
            btnOleConnect.TabIndex = 3;
            btnOleConnect.Text = "Ole Connect";
            btnOleConnect.UseVisualStyleBackColor = true;
            btnOleConnect.Click += btnOleConnect_Click;
            // 
            // tbxOleCon
            // 
            tbxOleCon.Location = new Point(12, 41);
            tbxOleCon.Name = "tbxOleCon";
            tbxOleCon.Size = new Size(100, 23);
            tbxOleCon.TabIndex = 2;
            // 
            // btnQuery
            // 
            btnQuery.Location = new Point(191, 108);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(85, 23);
            btnQuery.TabIndex = 5;
            btnQuery.Text = "Query";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnQuery_Click;
            // 
            // tbxQuery
            // 
            tbxQuery.Location = new Point(12, 84);
            tbxQuery.Name = "tbxQuery";
            tbxQuery.Size = new Size(264, 23);
            tbxQuery.TabIndex = 4;
            // 
            // tbxResult
            // 
            tbxResult.Location = new Point(12, 137);
            tbxResult.Multiline = true;
            tbxResult.Name = "tbxResult";
            tbxResult.Size = new Size(264, 148);
            tbxResult.TabIndex = 6;
            // 
            // SQLDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 297);
            Controls.Add(tbxResult);
            Controls.Add(btnQuery);
            Controls.Add(tbxQuery);
            Controls.Add(btnOleConnect);
            Controls.Add(tbxOleCon);
            Controls.Add(btnSqlConnect);
            Controls.Add(txtTenSerVer);
            Name = "SQLDatabase";
            Text = "SQLDatabase";
            Load += SQLDatabase_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenSerVer;
        private Button btnSqlConnect;
        private Button btnOleConnect;
        private TextBox tbxOleCon;
        private Button btnQuery;
        private TextBox tbxQuery;
        private TextBox tbxResult;
    }
}