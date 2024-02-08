using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {

            private readonly IEmailService _emailService;
            private readonly MyContext _dbContext; // Inject your DbContext here

            public AnnouncementController(IEmailService emailService, MyContext dbContext)
            {
                _emailService = emailService;
                _dbContext = dbContext;
            }

            [HttpPost]
            [Route("api/announcements/send")]
            public async Task<IActionResult> SendAnnouncement([FromBody] AnnouncementDTO announcementDto)
            {
                // Validation, authentication, etc.

                // Get email addresses of all teachers
                var teacherEmails = _dbContext.Teachers.Select(t => t.Email).ToList();

                // Get email addresses of all students
                var studentEmails = _dbContext.Students.Select(s => s.Email).ToList();

                // Combine all email addresses
                var allEmails = new List<string>();
                allEmails.AddRange(teacherEmails);
                allEmails.AddRange(studentEmails);

                // Send announcement email to all recipients
                await _emailService.SendAnnouncementEmail(announcementDto, allEmails);

                return Ok();
            }
        
    }
}

