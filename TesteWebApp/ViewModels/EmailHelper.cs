using System;
using System.Net.Mail;

namespace TesteWebApp.Models
{
    public class EmailHelper
    {
        public bool SendEmailPasswordReset(string userEmail, string link)
        {
            MailMessage mailMessage = new();
            mailMessage.From = new MailAddress("vkulessatestes@gmail.com");
            mailMessage.To.Add(new MailAddress(userEmail));

            mailMessage.Subject = "Password Reset";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = link;

            SmtpClient client = new();
            client.Credentials = new System.Net.NetworkCredential("vkulessatestes@gmail.com", "Jlqp@4464");
            client.Host = "smtp.gmail.com";
            client.Port = 587;

            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception)
            {
                // log exception
            }
            return false;
        }
    }
}
