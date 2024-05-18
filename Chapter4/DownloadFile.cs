using System.Net;
using System.Security.Policy;
using System.Text;

namespace Chapter4
{
    public partial class DownloadFile : Form
    {
        public DownloadFile()
        {
            InitializeComponent();
        }
        WebClient wc = new WebClient();
        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                wc.DownloadFile(tbxUrl.Text, tbxDesFile.Text);
                rtbContent.Text = OpenReader(tbxDesFile.Text);
                MessageBox.Show("File downloaded", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WebException wex)
            {
                rtbContent.Text = wex.Message;
            }
        }
        private string OpenReader(string argv)
        {
            string response = "";
            Stream strm = wc.OpenRead(argv);
            StreamReader sr = new StreamReader(strm);
            while (sr.Peek() > -1)
            {
                response += sr.ReadLine();
            }
            sr.Close();
            return response;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rtbContent.Text = OpenReader(tbxDesFile.Text);
        }
    }
}
