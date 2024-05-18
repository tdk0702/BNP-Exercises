using System.Net;
using System.Net.Sockets;

namespace Chapter3
{
    public partial class UDPChat : Form
    {
        public UDPChat()
        {
            InitializeComponent();
        }
        string _localPort = "10";
        string _remotePort = "1000";
        UdpClient _applications = new UdpClient();
        Thread _thread;
        bool _exit = false;
        delegate void ClearCacheReceivedData(string Data, string RemoteHost);


        private void btnSend_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(tbxIpAdd.Text, out ip))
                MessageBox.Show("Hãy nhập chính xác IP của người nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SentData();
                lbxSend.Items.Insert(0, tbxSend.Text);
                tbxSend.Clear();
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _localPort = this.tbxLocalPort.Text;
            _remotePort = this.tbxPort.Text;
            _applications = new UdpClient(int.Parse(_localPort));
            _thread = new Thread(Explore);
            _thread.Start();
            this.btnSend.Click += btnSend_Click;
            this.btnSend.Enabled = true;
            this.btnConnect.Enabled = false;
            tbxIpAdd.ReadOnly = tbxLocalPort.ReadOnly = tbxPort.ReadOnly = true;

        }
        private void ReceivedData(string Data, string RemoteHost)
        {
            if (lbxReceive.InvokeRequired)
            {
                ClearCacheReceivedData clearCacheReceivedData = new ClearCacheReceivedData(ReceivedData);
                lbxReceive.Invoke(clearCacheReceivedData, new object[] { Data, RemoteHost });
                return;
            }
            string msg = "";
            msg = "(Người gửi: " + RemoteHost + ")" + Data;
            lbxReceive.Items.Insert(0, msg);
        }
        private void SentData()
        {
            byte[] msg;
            msg = System.Text.Encoding.UTF8.GetBytes(tbxSend.Text);
            _applications.Send(msg, msg.Length, tbxIpAdd.Text, int.Parse(_remotePort));
        }
        private void Explore()
        {
            IPAddress ip;
            byte[] msg;
            string str = "";
            ip = Dns.GetHostEntry(_remotePort).AddressList[0];
            IPEndPoint ep = new IPEndPoint(ip, Convert.ToInt16(_remotePort));
            while (_exit == false)
            {
                Application.DoEvents();
                if (_applications.Available > 0)
                {
                    msg = _applications.Receive(ref ep);
                    str = System.Text.Encoding.UTF8.GetString(msg);
                    ReceivedData(str, ep.Address.ToString());
                }
            }
        }

    }
}
