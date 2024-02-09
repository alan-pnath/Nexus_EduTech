using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using NexusEduTech_BackEnd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly MyContext _dbContext;

        public AnnouncementController(IEmailService emailService, MyContext dbContext)
        {
            _emailService = emailService;
            _dbContext = dbContext;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendAnnouncement([FromBody] AnnouncementDTO announcementDto)
        {
            try
            {
                // Validation, authentication, etc.

                List<string> recipients = new List<string>();

                switch (announcementDto.RecipientType)
                {
                    case RecipientType.All:
                        recipients = GetAllEmails();
                        break;
                    case RecipientType.Teachers:
                        recipients = GetTeacherEmails();
                        break;
                    case RecipientType.Student:
                        if (announcementDto.StudentEmail != null)
                        {
                            recipients.Add(announcementDto.StudentEmail);
                        }
                        break;
                    default:
                        return BadRequest("Invalid recipient type");
                }

                if (recipients.Any())
                {
                    await _emailService.SendAnnouncementEmail(announcementDto, recipients);
                    return Ok("Announcement sent successfully");
                }
                else
                {
                    return BadRequest("No recipients found");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        private List<string> GetAllEmails()
        {
            var teacherEmails = _dbContext.Teachers.Select(t => t.Email).ToList();
            var studentEmails = _dbContext.Students.Select(s => s.Email).ToList();
            return teacherEmails.Concat(studentEmails).ToList();
        }

        private List<string> GetTeacherEmails()
        {
            return _dbContext.Teachers.Select(t => t.Email).ToList();
        }
    }
}
