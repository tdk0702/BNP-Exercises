using System.Net;
using System.Security.Policy;
using System.Text;
using System.Web;

namespace Chapter4
{
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
        }
        public string getHTTP(string szURL, string szPost)
        {
            HttpWebRequest httprequest;
            HttpWebResponse httpresponse;
            StreamReader bodyreader;
            string bodytext = "";
            Stream responsestream;
            Stream requestStream;
            httprequest = (HttpWebRequest)WebRequest.Create(szURL);
            httprequest.Method = "POST";
            httprequest.ContentType =
            "application/x-www-form-urlencoded";
            httprequest.ContentLength = szPost.Length;
            requestStream = httprequest.GetRequestStream();
            requestStream.Write(Encoding.ASCII.GetBytes(szPost), 0,
            szPost.Length);
            requestStream.Close();
            httpresponse = (HttpWebResponse)httprequest.GetResponse();
            responsestream = httpresponse.GetResponseStream();
            bodyreader = new StreamReader(responsestream);
            bodytext = bodyreader.ReadToEnd();
            return bodytext;
        }

        private void btnCapture_Click(object sender, System.EventArgs e)
        {
            tbxPost.Text = HttpUtility.UrlEncode(tbxPost.Text);
            rtbGet.Text = getHTTP(tbxUrl.Text, "tbPost=" + tbxPost.Text);
        }

    }
}
