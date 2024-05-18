using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Examples
    {
        public void Example() {
            //Ex1
            Byte[] b = new Byte[4];
            b[0] = 192;
            b[1] = 168;
            b[2] = 10;
            b[3] = 10;
            IPAddress Ip1 = new IPAddress(b);
            //Ex2
            IPAddress Ip2 = new IPAddress(16885952);
            //Ex3
            IPAddress Ip3 = IPAddress.Parse("172.16.1.1");
            //Ex4
            long So = 192 * 256 ^ 0 + 168 * 256 ^ 1 + 1 * 256 ^ 2 + 2 * 256 ^ 3;
            IPAddress Ip4 = new IPAddress(So);
        }
        private void KiemTra()
        {
            IPAddress ip;
            String Ip4 = "127.0.0.1";
            String Ip5 = "999.0.0.1";
            MessageBox.Show(IPAddress.TryParse(Ip4, out ip).ToString());
            MessageBox.Show(IPAddress.TryParse(Ip5, out ip).ToString());
        }
        void ChuyenDoi()
        {
            IPAddress Ip3 = new IPAddress(16885952);
            Byte[] b = new Byte[4];
            b = Ip3.GetAddressBytes();
            MessageBox.Show("Address: " + b[0] + "." + b[1] + "." + b[2] + "." + b[3]);
        }
        private void TaoEndpoint()
        {
            // Tạo một địa chỉ IP
            IPAddress IPAdd = IPAddress.Parse("127.0.0.1");
            // Truyền vào cho hàm khởi tạo để tạo IPEndpoint
            IPEndPoint IPep = new IPEndPoint(IPAdd, 10000);
        }
        private void TaoEndPointBoiTenMay()
        {
            IPAddress IPAdd;
            //tạo đối tượng IP từ tên của máy thông qua phương thức tĩnh Dns.GetHostAddresses của lớp DNS
            IPAdd = Dns.GetHostAddresses("Localhost")[0];
            IPEndPoint IPep = new IPEndPoint(IPAdd, 10000);
        }
        private void ShowIPs()
        {
            // Lấy tất cả địa chỉ IP của máy
            IPAddress[] add = Dns.GetHostAddresses("Nhiem-PC");
            foreach (IPAddress ip in add)
            {
                MessageBox.Show(ip.ToString());
            }
            //Cách 2
            //for (int i = 0; i < add.Length; i++)
            //{
            //    MessageBox.Show(add[i].ToString());
            //}
        }
        private void CreatIPHostEntry()
        {
            IPHostEntry iphe1, iphe2, iphe3;
            IPAddress ipadd = IPAddress.Parse("127.0.0.1");
            iphe1 = Dns.GetHostEntry("Notebook");
            iphe2 = Dns.GetHostEntry("127.0.0.1");
            iphe3 = Dns.GetHostEntry(ipadd);
            MessageBox.Show(iphe1.HostName); MessageBox.Show(iphe2.HostName);
            MessageBox.Show(iphe3.HostName);
        }


    }
}
