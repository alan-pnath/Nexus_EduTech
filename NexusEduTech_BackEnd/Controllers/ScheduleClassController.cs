﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleClassController : ControllerBase
    {
        private readonly ScheduleClassRepository _scheduleClassRepository;

        public ScheduleClassController(ScheduleClassRepository scheduleClassRepository)
        {
            _scheduleClassRepository = scheduleClassRepository;
        }
        [HttpPost,Route("AssignTeacher")]
        public IActionResult AssignTeacher(ScheduleClassDTO data)
        {
            _scheduleClassRepository.AssignTeacher(data);
            return Ok(data);
        }
        [HttpGet,Route("ViewSchedule")]
        public IActionResult ViewSchedule()
        {
            return Ok(_scheduleClassRepository.ViewSchedules());
        }
        [HttpGet,Route("GetWithTeacherNameSubjectName/{teacherName}/{subName}")]
        public IActionResult GetWithTeacherNameSubjectName(string teacherName,string subName)
        {
            try
            {
                return Ok(_scheduleClassRepository.GetWithTeacherNameSubjectName(teacherName, subName));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetScheduleClassByStudentId/{id}")]
        public IActionResult GetScheduleClassByStudentId(int id)
        {
            try
            {
                return Ok(_scheduleClassRepository.GetScheduleClassByStudentId(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut,Route("EditScheduleClass/{id}")]
        public IActionResult EditScheduleClass(int id)
        {
            try
            {
                _scheduleClassRepository.EditScheduleClass(id);
                return Ok("updated");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("DeleteScheduleClass/{id}")]
        public IActionResult DeleteScheduleClass(int id)
        {
            try
            {
                _scheduleClassRepository.DeleteScheduleClass(id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
