using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Chapter5
{
    public partial class POP3Delete : Form
    {
        public POP3Delete()
        {
            InitializeComponent();
        }
        NetworkStream nStr;
        TcpClient tcp;
        string NEW_LINE = "\r\n";

        private void btnDo_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(tbxServer.Text, 110);
            NetworkStream networkStream = client.GetStream();
            StreamReader reader = new StreamReader(networkStream);
            string welcomeMessage = reader.ReadLine();
            lstLogs.Items.Add(welcomeMessage);
            RunCmd("USER " + tbxUser.Text + NEW_LINE, networkStream);
            RunCmd("PASS " + tbxPass.Text + NEW_LINE, networkStream);
            RunCmd("DELE 1" + NEW_LINE, networkStream);
            RunCmd("QUIT\r\n", networkStream);
        }
        private void RunCmd(string cmd, NetworkStream networkStream)
        {
            byte[] bData = Encoding.ASCII.GetBytes(cmd.ToCharArray());
            networkStream.Write(bData, 0, bData.Length);
            StreamReader reader = new StreamReader(networkStream);
            string retValue = reader.ReadLine();
            WriteToLogs(retValue + NEW_LINE, new FileStream("Logs.txt",FileMode.OpenOrCreate));
            lstLogs.Items.Add(cmd.Replace(NEW_LINE, ""));
            lstLogs.Items.Add(retValue);
            lstLogs.Items.Add("");
        }

        public void WriteToLogs(string msg, FileStream file)
        {
            byte[] bData = Encoding.ASCII.GetBytes(msg.ToCharArray());
            file.Write(bData, 0, bData.Length);
            file.Flush();
        }
    }
}
