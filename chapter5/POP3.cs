using Microsoft.VisualBasic;
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
    public partial class POP3 : Form
    {
        public POP3()
        {
            InitializeComponent();
        }
        NetworkStream nStr;
        TcpClient tcp;


        private void btnConnect_Click(object sender, EventArgs e)
        {
            tcp = new TcpClient(tbxServer.Text, 110);
            nStr = tcp.GetStream();
            StreamReader sr = new StreamReader(nStr);
            tbxBody.Text = sr.ReadLine() + "\r\n";
            MessageBox.Show("Connect successed!", "Information");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                tbxBody.Text += SendPop3("USER " + tbxUser.Text + "\r\n");
                tbxBody.Text += SendPop3("PASS " + tbxPass.Text + "\r\n");
                MessageBox.Show("Login successed!", "Information");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error!" + exp.ToString(), "Information");
            }

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                tbxBody.Text += SendPop3("STAT " + "\r\n");
                WriteToLogs(tbxBody.Text.ToString());
                MessageBox.Show("Successed!", "Information");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error!" + exp.ToString(), "Information");
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                tbxBody.Text += SendPop3("QUIT " + "\r\n");
                WriteToLogs(tbxBody.Text.ToString());
                MessageBox.Show("Successed!", "Information");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error!" + exp.ToString(), "Information");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                tcp.Close();
                nStr.Close();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error!" + exp.ToString(), "Information");
            }

        }
        public string SendPop3(string cmd)
        {
            StreamReader sr = new StreamReader(nStr);
            byte[] data = Encoding.ASCII.GetBytes(cmd.ToCharArray());
            nStr.Write(data, 0, data.Length);
            return sr.ReadLine() + "\r\n";
        }
        public void WriteToLogs(string msg)
        {
            byte[] bData = Encoding.ASCII.GetBytes(msg.ToCharArray());
            nStr.Write(bData, 0, bData.Length);
            nStr.Flush();
        }

    }
}
