using System.Net;

namespace Chapter4
{
    public partial class Example : Form
    {
        public Example()
        {
            InitializeComponent();
        }
        private string getHTTP(string szURL)
        {
            HttpWebRequest httpRequest;
            HttpWebResponse httpResponse;
            String bodyText = "";
            Stream responseStream;
            Byte[] RecvBytes = new Byte[Byte.MaxValue];
            Int32 bytes;
            httpRequest = (HttpWebRequest)WebRequest.Create(szURL);
            httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            responseStream = httpResponse.GetResponseStream();
            while (true)
            {
                bytes = responseStream.Read(RecvBytes,
                0, RecvBytes.Length);
                if (bytes <= 0) break;
                bodyText += System.Text.Encoding.UTF8.GetString(RecvBytes, 0, bytes);
            }
            return bodyText;
        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            rtbGet.Text = getHTTP(tbxUrl.Text);
        }
    }
}
