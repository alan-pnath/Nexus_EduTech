using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentRepository _studentRepository;

        public StudentController(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost, Route("AddStudent")]
        public IActionResult Add(StudentDTO data)
        {
            try
            {
                _studentRepository.Add(data);
                return Ok("Student Added");
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpPut, Route("UpdateStudent")]
        public IActionResult Update(StudentDTO data)
        {
            try
            {
                _studentRepository.Update(data);
                return Ok("Student Updated");
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpDelete, Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _studentRepository.Delete(id);
                return Ok("Student Deleted");
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpGet, Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_studentRepository.GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpGet, Route("GetByStudentId/{id}")]
        public IActionResult GetByStudentId(int id)
        {
            try
            {
                return Ok(_studentRepository.GetByStudentId(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpGet, Route("GetByStd/{std}")]
        public IActionResult GetByStd(string std)
        {
            try
            {
                return Ok(_studentRepository.GetByStd(std));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpGet, Route("GetByStdSec/{std}/{sec}")]
        public IActionResult GetByStdSec(string std, string sec)
        {
            try
            {
                return Ok(_studentRepository.GetByStdSec(std, sec));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
        [HttpGet,Route("ViewResults")]
        public IActionResult Results()
        {
            try
            {
                return Ok(_studentRepository.Results());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet,Route("ViewResultById/{id}")]
        public IActionResult ResultById(int id) 
        {
            try
            {
                return Ok(_studentRepository.ResultsById(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
