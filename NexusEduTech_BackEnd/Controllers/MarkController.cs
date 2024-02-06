using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkController : ControllerBase
    {
        private readonly MarkRepository _markRepository;

        public MarkController(MarkRepository markRepository)
        {
            _markRepository = markRepository;
        }
        [HttpPost, Route("AddMark")]
        public IActionResult AddMark(MarksDTO data)
        {
            try
            {
                _markRepository.AddMark(data);
                return Ok("Mark Added");
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
        [HttpPut, Route("UpdateStudent")]
        public IActionResult UpdateMark(MarksDTO data)
        {
            try
            {
                _markRepository.UpdateMark(data);
                return Ok("Mark Updated");
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
