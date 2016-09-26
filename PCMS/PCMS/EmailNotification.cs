using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Windows.Forms;

/// <summary>
/// 19 July 2016
/// http://www.codeproject.com/Tips/520998/Send-Email-from-Yahoo-GMail-Hotmail-Csharp
/// </summary>

namespace PCMS
{
    class EmailNotification
    {
        private string from;
        private List<string> to;
        private string subject;
        private string message;
        private string smtpAddress;
        private int portNumber;
        private bool enableSSL;
        private string password;

        public EmailNotification(List<string> to, string subject, string message)
        {
            //Get all the information needed to send the email
            from = ConfigurationManager.AppSettings["username"];
            this.to = to;
            this.subject = subject;
            this.message = message + Environment.NewLine + Environment.NewLine + "This is an automated emailer please do not reply.";
            smtpAddress = ConfigurationManager.AppSettings["smtpAddress"];
            portNumber = int.Parse(ConfigurationManager.AppSettings["portNumber"]);
            enableSSL = bool.Parse(ConfigurationManager.AppSettings["enableSSL"]);
            password = EncryptionHelper.Decrypt(ConfigurationManager.AppSettings["password"]);
        }
        public void SendMail()
        {
            using (MailMessage mail = new MailMessage())
            {
                //Build the email
                mail.From = new MailAddress(from);
                foreach (var item in to)
                {
                    mail.To.Add(item);
                }
                mail.Subject = subject;
                mail.Body = message;
                mail.IsBodyHtml = true;

                using (SmtpClient client = new SmtpClient(smtpAddress, portNumber))
                {
                    //Send the email.
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(from, password);
                    client.EnableSsl = enableSSL;

                    try
                    {
                        client.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured: " + ex.Message + Environment.NewLine + Environment.NewLine
                            + "Please check the email notification setting.");
                    }
                }
            }
        }
    }
}
