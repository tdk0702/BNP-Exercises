using System.Net;
using System;
using System.Net.Sockets;

namespace Chapter5
{
    public partial class SMTPSend : Form
    {
        public SMTPSend()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(tbxIp.Text), int.Parse(tbxPort.Text));
            TcpClient client = new TcpClient();
            client.Connect(iep); 
            string Data = "Helo";
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            sw.WriteLine(Data);
            sw.Flush();
            Data = "MAIL FROM: <" + tbxFrom.Text + ">";
            sw.WriteLine(Data);
            sw.Flush();
            Data = "RCPT TO: <" + tbxTo.Text + ">";
            sw.WriteLine(Data);
            sw.Flush();
            Data = "Data";
            sw.WriteLine(Data);
            sw.Flush(); 
            Data = "SUBJECT:" + tbxSubject.Text + "\r\n" + tbxBody.Text + "\r\n" + "." + "\r\n";
            sw.WriteLine(Data);
            sw.Flush(); 
            Data = "QUIT";
            sw.WriteLine(Data);
            sw.Flush();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
