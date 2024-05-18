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

namespace Chapter3.TCPChat
{
    public partial class TCPServer : Form
    {
        public TCPServer()
        {
            InitializeComponent();
        }
        static class ChatServer
        {
            public static List<string> htUsers = new List<string>();
            public static void AddUser(TcpClient tcp, string user)
            {

            }
            public static void RemoveUser(TcpClient tcp)
            {

            }
            public static void SendMessage(string user, string message)
            {

            }
        }
        class Connection
        {
            TcpClient tcpClient;
            private Thread thrSender;
            private StreamReader srReceiver;
            private StreamWriter swSender;
            private string currUser = string.Empty;
            private string strResponse;
            public Connection(TcpClient tcpCon)
            {
                tcpClient = tcpCon;
                thrSender = new Thread(AcceptClient);
                thrSender.Start();
            }
            private void CloseConnection()
            {
                tcpClient.Close();
                srReceiver.Close();
                swSender.Close();
            }
            private void AcceptClient()
            {
                srReceiver = new System.IO.StreamReader(tcpClient.GetStream());
                swSender = new System.IO.StreamWriter(tcpClient.GetStream());
                currUser = srReceiver.ReadLine();
                if (currUser != "")
                {
                    if (ChatServer.htUsers.Contains(currUser) == true)
                    {
                        swSender.WriteLine("0|This username already exists.");
                        swSender.Flush();
                        CloseConnection();
                        return;
                    }
                    else if (currUser == "Administrator")
                    {
                        swSender.WriteLine("0|This username is reserved.");
                        swSender.Flush();
                        CloseConnection();
                        return;
                    }
                    else
                    {
                        swSender.WriteLine("1");
                        swSender.Flush();
                        ChatServer.AddUser(tcpClient, currUser);
                    }
                }
                else
                {
                    CloseConnection();
                    return;
                }
                try
                {
                    while ((strResponse = srReceiver.ReadLine()) != "")
                    {
                        if (strResponse == null)
                        {
                            ChatServer.RemoveUser(tcpClient);
                        }
                        else
                        {
                            ChatServer.SendMessage(currUser, strResponse);
                        }
                    }
                }
                catch
                {
                    ChatServer.RemoveUser(tcpClient);
                }
            }
        }
    }
}
