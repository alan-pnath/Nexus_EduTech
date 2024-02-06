using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly ClassRepository _classRepository;

        public ClassController(ClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        [HttpPost,Route("AddClass")]
        public IActionResult AddClass(ClassDTO data)
        {
            try
            {
                _classRepository.AddClass(data);
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("DeleteClass/{id}")]
        public IActionResult DeleteClass(int  id)
        {
            try
            {
                _classRepository.DeleteClass(id);
                return Ok("Deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetAllClasses")]
        public IActionResult GetAllClasses()
        {
            try
            {
                return Ok(_classRepository.GetAllClasses());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut,Route("UpdateClass")]
        public IActionResult UpdateClasses(ClassDTO data)
        {
            try
            {
                _classRepository.UpdateClass(data);
                return Ok("Updated");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
