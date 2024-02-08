using NexusEduTech_BackEnd.DTOs;

namespace NexusEduTech_BackEnd.Repository
{
    public interface IEmailService
    {
        Task SendAnnouncementEmail(AnnouncementDTO announcementDto, List<string> recipients);
    }
}
