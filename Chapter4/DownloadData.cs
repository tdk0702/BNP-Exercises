using System.Net;
using System.Security.Policy;
using System.Text;

namespace Chapter4
{
    public partial class DownloadData : Form
    {
        public DownloadData()
        {
            InitializeComponent();
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (tbxUrl.Text.Trim() == "")
            {
                MessageBox.Show("Please input URL", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            WebClient wc = new WebClient();
            try
            {
                byte[] response = wc.DownloadData(tbxUrl.Text);
                rtbContent.Text = Encoding.ASCII.GetString(response);
            }
            catch (WebException wex)
            {
                rtbContent.Text = wex.Message;
            }
        }
    }
}
