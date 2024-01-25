using BookAPI.Models.DTOs;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using Org.BouncyCastle.Security;
using System.Net.Mail;
using BookAPI.Repositories.IEService;
using static BookAPI.Models.DTOs.DTOs;

namespace BookAPI.Repositories
{
    public class EmailService : IEmailInterface
    {
        private readonly IConfiguration configuration;

        public EmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void SendEmail(EmailDTO request)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(configuration.GetSection("EmailSettings:EmailUserName").Value));

            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect(configuration.GetSection("EmailSettings:EmailHost").Value, 587, SecureSocketOptions.StartTls);

            smtp.Authenticate(configuration.GetSection("EmailSettings:EmailUserName").Value, configuration.GetSection("EmailSettings:EmailPassword").Value);

            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
