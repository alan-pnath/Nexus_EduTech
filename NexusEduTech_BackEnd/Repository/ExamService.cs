using NexusEduTech_BackEnd.DTOs;
using System.Net.Mail;
using System.Net;

namespace NexusEduTech_BackEnd.Repository
{
    public class ExamService : IEmailService
    {
        public Task SendAnnouncementEmail(AnnouncementDTO announcementDto, List<string> recipients)
        {

                // Configure SMTP settings (replace with your SMTP server details)
                var smtpClient = new SmtpClient("smtp.example.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("your-email@example.com", "your-password"),
                    EnableSsl = true,
                };

                // Construct email message
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("your-email@example.com"),
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

