using NexusEduTech_BackEnd.Models;
using System.ComponentModel.DataAnnotations;

namespace NexusEduTech_BackEnd.DTOs
{
    public class MarksDTO
    {
     /*   public int MarkId { get; set; }*/

        public int StudentId { get; set; }
        
        public int ExamId { get; set; }
        
        public int mark { get; set; }
    }
}
