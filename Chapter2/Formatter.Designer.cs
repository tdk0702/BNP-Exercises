namespace Chapter2
{
    partial class Formatter
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
            btnSOAPSerial = new Button();
            btnSOAPDeserial = new Button();
            btnBinaryDeserial = new Button();
            btnBinarySerial = new Button();
            btnXMLDeserial = new Button();
            btnXMLSerial = new Button();
            SuspendLayout();
            // 
            // btnSOAPSerial
            // 
            btnSOAPSerial.Location = new Point(12, 12);
            btnSOAPSerial.Name = "btnSOAPSerial";
            btnSOAPSerial.Size = new Size(128, 46);
            btnSOAPSerial.TabIndex = 0;
            btnSOAPSerial.Text = "SOAP Serialization";
            btnSOAPSerial.UseVisualStyleBackColor = true;
            btnSOAPSerial.Click += this.btnSOAPSerial_Click;
            // 
            // btnSOAPDeserial
            // 
            btnSOAPDeserial.Location = new Point(12, 64);
            btnSOAPDeserial.Name = "btnSOAPDeserial";
            btnSOAPDeserial.Size = new Size(128, 46);
            btnSOAPDeserial.TabIndex = 1;
            btnSOAPDeserial.Text = "SOAP Deserialization";
            btnSOAPDeserial.UseVisualStyleBackColor = true;
            btnSOAPDeserial.Click += this.btnSOAPDeserial_Click;
            // 
            // btnBinaryDeserial
            // 
            btnBinaryDeserial.Location = new Point(146, 64);
            btnBinaryDeserial.Name = "btnBinaryDeserial";
            btnBinaryDeserial.Size = new Size(128, 46);
            btnBinaryDeserial.TabIndex = 3;
            btnBinaryDeserial.Text = "Binary Deserialization";
            btnBinaryDeserial.UseVisualStyleBackColor = true;
            btnBinaryDeserial.Click += this.btnBinaryDeserial_Click;
            // 
            // btnBinarySerial
            // 
            btnBinarySerial.Location = new Point(146, 12);
            btnBinarySerial.Name = "btnBinarySerial";
            btnBinarySerial.Size = new Size(128, 46);
            btnBinarySerial.TabIndex = 2;
            btnBinarySerial.Text = "Binary Serialization";
            btnBinarySerial.UseVisualStyleBackColor = true;
            btnBinarySerial.Click += this.btnBinarySerial_Click;
            // 
            // btnXMLDeserial
            // 
            btnXMLDeserial.Location = new Point(280, 64);
            btnXMLDeserial.Name = "btnXMLDeserial";
            btnXMLDeserial.Size = new Size(128, 46);
            btnXMLDeserial.TabIndex = 5;
            btnXMLDeserial.Text = "XML Deserialization";
            btnXMLDeserial.UseVisualStyleBackColor = true;
            btnXMLDeserial.Click += this.btnXMLDeserial_Click;
            // 
            // btnXMLSerial
            // 
            btnXMLSerial.Location = new Point(280, 12);
            btnXMLSerial.Name = "btnXMLSerial";
            btnXMLSerial.Size = new Size(128, 46);
            btnXMLSerial.TabIndex = 4;
            btnXMLSerial.Text = "XML Serialization";
            btnXMLSerial.UseVisualStyleBackColor = true;
            btnXMLSerial.Click += this.btnXMLSerial_Click;
            // 
            // Formatter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 120);
            Controls.Add(btnXMLDeserial);
            Controls.Add(btnXMLSerial);
            Controls.Add(btnBinaryDeserial);
            Controls.Add(btnBinarySerial);
            Controls.Add(btnSOAPDeserial);
            Controls.Add(btnSOAPSerial);
            Name = "Formatter";
            Text = "Formatter";
            Load += SoapFormatter_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSOAPSerial;
        private Button btnSOAPDeserial;
        private Button btnBinaryDeserial;
        private Button btnBinarySerial;
        private Button btnXMLDeserial;
        private Button btnXMLSerial;
    }
}