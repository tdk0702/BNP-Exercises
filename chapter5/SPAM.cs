using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    internal class SPAM
    {
        public void Process(string host, TextBox tbStatus)
        {
            TcpClient clientSocket = new TcpClient(host, 110);
            NetworkStream NetStrm = clientSocket.GetStream();
            StreamReader RdStrm = new StreamReader(NetStrm);
            string Data = sendPOP3("STAT\r\n", NetStrm);
            string[] BreakDown = Data.Split(" ".ToCharArray());
            int messageCount = Convert.ToInt16(BreakDown[1]);
            for (int i = 1; i <= messageCount; i++)
            {
                StringBuilder message = new StringBuilder("");
                Data = "RETR " + Convert.ToString(i) + "\r\n";
                byte[] szData =
                System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray()); NetStrm.Write(szData, 0, szData.Length);
                string szTemp = RdStrm.ReadLine();
                while (szTemp != ".")
                {
                    message.Append(szTemp);
                    tbStatus.Text += szTemp + "\r\n";
                    szTemp = RdStrm.ReadLine();
                }
                if (message.ToString().IndexOf("free money") >= 0)
                {
                    sendPOP3("DELE " + Convert.ToString(i) + "\r\n", NetStrm);
                }
            }
        }
        public string sendPOP3(string cmd, NetworkStream ns)
        {
            byte[] data = Encoding.ASCII.GetBytes(cmd.ToCharArray());
            ns.Write(data, 0, data.Length);
            data = new byte[4096];
            ns.Read(data, 0, data.Length);
            return Encoding.ASCII.GetString(data) + "\r\n";
        }
    }
}
