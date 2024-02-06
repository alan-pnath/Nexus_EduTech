using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly ExamRepository _examRepository;

        public ExamController(ExamRepository examRepository)
        {
            _examRepository = examRepository;
        }
        [HttpPost, Route("AddExam")]
        public IActionResult AddExam(ExamDTO data)
        {
            _examRepository.AddExam(data);
            return Ok("Exam Added");
        }

        [HttpPut, Route("UpdateExam")]
        public IActionResult UpdateExam(ExamDTO data)
        {
            _examRepository.UpdateExam(data);
            return Ok("Exam Updated");
        }

        [HttpDelete, Route("DeleteExam/{id}")]
        public IActionResult DeleteExam(int id)
        {
            _examRepository.DeleteExam(id);
            return Ok("Exam Deleted");
        }

        [HttpGet, Route("GetAll")]
        public IActionResult GetAll()
        {

            return Ok(_examRepository.GetAll());
        }

        [HttpGet, Route("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            return Ok(_examRepository.GetByName(name));
        }
    }
}
