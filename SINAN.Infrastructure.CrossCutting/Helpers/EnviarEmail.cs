using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;
using System.Web.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.IO;

namespace SINAN.Infrastructure.CrossCutting.Helpers
{
    public class EnviarEmail
    {
        private static Configuration configurationFile = WebConfigurationManager.OpenWebConfiguration("~\\Web.config");
        private static MailSettingsSectionGroup mailSettings = configurationFile.GetSectionGroup("system.net/mailSettings") as MailSettingsSectionGroup;

        public static void SendEmail(string from, string title, string to, string name, string subject, string body)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = mailSettings.Smtp.Network.Host;
                smtp.Port = mailSettings.Smtp.Network.Port;
                smtp.EnableSsl = mailSettings.Smtp.Network.EnableSsl;
                smtp.UseDefaultCredentials = mailSettings.Smtp.Network.DefaultCredentials;
                smtp.Credentials = new System.Net.NetworkCredential(mailSettings.Smtp.Network.UserName, mailSettings.Smtp.Network.Password);

                //ServicePointManager.ServerCertificateValidationCallback =
                //delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                //{ return true; };

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, title);
                mail.To.Add(new MailAddress(to, name));
                mail.Subject = subject;
                mail.Body = body;              

                smtp.Send(mail);
            }
            catch (Exception)
            {
                throw;
            }
        }        
    }
}