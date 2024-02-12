using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherAttendenceController : ControllerBase
    {
        private readonly TeacherAttendenceRepository _teacherAttendenceRepository;

        public TeacherAttendenceController(TeacherAttendenceRepository teacherAttendenceRepository)
        {
            _teacherAttendenceRepository = teacherAttendenceRepository;
        }
        [HttpPost, Route("AddTeacherAttendence")]
        public IActionResult AddTeacherAttendence(TeacherAttendenceDTO data)
        {
            try
            {
                _teacherAttendenceRepository.AddTeacherAttendence(data);
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route(" GetTeacherAttendenceById/{id}")]
        public IActionResult GetTeacherAttendenceById(int id)
        {
            try
            {
                return Ok(_teacherAttendenceRepository.GetTeacherAttendenceById(id));

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetTeacherAttendencebyMonth/{month}")]
        public IActionResult GetStudentAttendencebyMonth(int month)
        {
            try
            {
                return Ok(_teacherAttendenceRepository.GetTeacherAttendencebyMonth(month).ToList());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost, Route("UpdateTeacherAttendence/{id}")]
        public IActionResult Update(TeacherAttendenceDTO data, int id)
        {
            try
            {
                _teacherAttendenceRepository.Update(data,id);
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
