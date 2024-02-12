using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendenceController : ControllerBase
    {
        private readonly StudentAttendenceRepository _studentAttendenceRepository;

        public StudentAttendenceController(StudentAttendenceRepository studentAttendenceRepository)
        {
            _studentAttendenceRepository = studentAttendenceRepository;
        }
        [HttpPost, Route("AddStudentAttendence")]
        public IActionResult AddStudentAttendence(StudentAttendenceDTO data)
        {
            try
            {
                _studentAttendenceRepository.AddStudentAttendence(data);
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route(" GetStudAttendenceById/{id}")]
        public IActionResult GetStudAttendenceById(int id)
        {
            try
            {
                return Ok(_studentAttendenceRepository.GetStudAttendenceById(id));

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetStudentAttendencebyMonth/{month}")]
        public IActionResult GetStudentAttendencebyMonth(int month)
        {
            try
            {
                return Ok(_studentAttendenceRepository.GetStudentAttendencebyMonth(month).ToList());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost, Route("UpdateStudentAttendence/{id}")]
        public IActionResult Update(StudentAttendenceDTO data, int id)
        {
            try
            {
                _studentAttendenceRepository.Update(data,id);
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetAttendenceByClassStdSec/{std}/{sec}")]
        public IActionResult GetAttendenceByClassStdSec(string std, string sec)
        {
            try
            {
                return Ok(_studentAttendenceRepository.GetAttendenceByClassStdSec(std, sec).ToList());

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
