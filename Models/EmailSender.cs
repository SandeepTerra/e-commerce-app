using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace e_commerce_app.Models
{
    public class EmailSender : IEmailSender
    {
        IConfiguration Configuration { get; }


        public EmailSender(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {

            string mailA = Configuration.GetValue<string>("EmailSender:Mail");
            string host = Configuration.GetValue<string>("EmailSender:Host");
            int port = Configuration.GetValue<int>("EmailSender:Port");
            string password = Configuration.GetValue<string>("EmailSender:Password");
            MailMessage mail = new MailMessage
            {
                From = new MailAddress(mailA),
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            };
            mail.To.Add(new MailAddress(email));

            using (var smtpClient = new SmtpClient(host, port))
            {

                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtpClient.Credentials = new System.Net.NetworkCredential(mailA, password);
                await smtpClient.SendMailAsync(mail).ConfigureAwait(false);
            }


        }

    }
}
