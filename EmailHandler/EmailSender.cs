using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailHandler
{
    public class EmailSender
    {
        #region instancia
        public static EmailSender Instancia { get; } = new EmailSender();
        #endregion

        public void SendEmail(string to, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient(EmailSettings.Default.SmtpServer);

                mail.From = new MailAddress(EmailSettings.Default.From);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                smtpServer.Port = EmailSettings.Default.Port;
                smtpServer.Credentials = new NetworkCredential(EmailSettings.Default.From, EmailSettings.Default.Paswword);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
                Console.WriteLine("Se envio el correo");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
