using AutoMapper;
using NexusEduTech_BackEnd.Models;
namespace NexusEduTech_BackEnd.DTOs
{
    public class ExamDTO
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public DateTime ExamDate { get; set; }
        public int Max_Mark { get; set; }
        public int class_Id { get; set; }
    }
}
