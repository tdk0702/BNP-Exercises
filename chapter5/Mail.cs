using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Chapter5
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage email = new MailMessage(new MailAddress(tbxFrom.Text),
                new MailAddress(tbxTo.Text));
            email.Subject = "email from .NET";
            email.Body = tbxBody.Text;
            SmtpClient client = new SmtpClient(tbxServer.Text);
            client.Credentials = CredentialCache.DefaultNetworkCredentials;
            client.Send(email);
        }
        private void SendWithAttach()
        {
            MailMessage email = new MailMessage(new MailAddress(tbxFrom.Text),
                new MailAddress(tbxTo.Text));
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != string.Empty)
            {
                Attachment fileAttachment = new Attachment(ofd.FileName);
                email.Attachments.Add(fileAttachment);
            }
            email.Priority = MailPriority.High;
            //email..BodyFormat = MailFormat.Html;
            email.Subject = "email from .NET";
            email.Body = tbxBody.Text;
            SmtpClient client = new SmtpClient(tbxServer.Text);
            client.Credentials = CredentialCache.DefaultNetworkCredentials;
            client.Send(email);
        }        
    }
}
