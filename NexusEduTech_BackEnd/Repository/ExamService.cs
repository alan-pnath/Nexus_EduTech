using NexusEduTech_BackEnd.DTOs;
using System.Net.Mail;
using System.Net;

namespace NexusEduTech_BackEnd.Repository
{
    public class EmailService : IEmailService
    {
        public async Task SendAnnouncementEmail(AnnouncementDTO announcementDto, List<string> recipients)
        {

            // Configure SMTP settings (replace with your SMTP server details)
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("neethur984@gmail.com", "bqupcyywpiluyjxr"),
                EnableSsl = true,
            };

            // Construct email message
            var mailMessage = new MailMessage
            {
                From = new MailAddress("neethur984@gmail.com"),
                Subject = "New Announcement",
                Body = announcementDto.AnnouncementContent,
            };

            // Add recipients
            foreach (var recipient in recipients)
            {
                mailMessage.To.Add(recipient);
            }

            // Send email
            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}

