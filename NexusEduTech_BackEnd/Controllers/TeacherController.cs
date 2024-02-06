using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacher teacherRepository;

        public TeacherController(ITeacher teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        [HttpGet, Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(teacherRepository.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetAllTeacherBySubject/{Subject}")]
        public IActionResult GetAllBySubject(string subject)
        {
            try
            {
                return Ok(teacherRepository.GetTeacherBySubject(subject));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetTeacher/{id}")]
        public IActionResult GetStaff(int id)
        {
            try
            {
                return Ok(teacherRepository.GetTeacher(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost, Route("AddTeacher")]
        public IActionResult AddTeacher(TeacherDTO data)
        {
            try
            {
                teacherRepository.AddTeacher(data);
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("EditTeacher")]
        public IActionResult EditTeacher(TeacherDTO data)
        {
            try
            {
                teacherRepository.UpdateTeacher(data);
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete, Route("Delete/{id}")]
        public IActionResult DeleteTeacher(int id)
        {
            try
            {
                teacherRepository.DeleteTeacher(id);
                return Ok("Teacher Deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
