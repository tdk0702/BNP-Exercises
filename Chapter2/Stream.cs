using System.Text;
using System.Windows.Forms;

namespace Chapter2
{
    public partial class Stream : Form
    {
        public Stream()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        FileStream fs;
        byte[] fileContents;
        AsyncCallback callback;
        delegate void InfoMessageDel(String info); 
        private void btnReadAsync_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            callback = new AsyncCallback(fs_StateChanged);
            fs = new FileStream(openFileDialog.FileName, FileMode.Open,
            FileAccess.Read, FileShare.Read, 4096, true);
            fileContents = new Byte[fs.Length];
            fs.BeginRead(fileContents, 0, (int)fs.Length, callback, null);
        }
        private void fs_StateChanged(IAsyncResult asyncResult)
        {
            if (asyncResult.IsCompleted)
            {
                string s = Encoding.UTF8.GetString(fileContents);
                InfoMessage(s);
                fs.Close();
            }
        }
        private void btnReadSync_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            Thread thdSyncRead = new Thread(new ThreadStart(syncRead));
            thdSyncRead.Start();
        }
        public void syncRead()
        {
            FileStream fs;
            try
            {
                fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            fs.Seek(0, SeekOrigin.Begin);
            byte[] fileContents = new byte[fs.Length];
            fs.Read(fileContents, 0, (int)fs.Length);
            string s = Encoding.UTF8.GetString(fileContents);
            InfoMessage(s);
            fs.Close();
        }
        public void InfoMessage(String info)
        {
            if (tbResults.InvokeRequired)
            {
                InfoMessageDel method = new InfoMessageDel(InfoMessage);
                tbResults.Invoke(method, new object[] { info });
                return;
            }
            tbResults.Text = info;
        }

    }
}
