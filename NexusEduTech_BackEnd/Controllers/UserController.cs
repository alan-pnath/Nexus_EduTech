using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.Models;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost,Route("AddUser")]
        public IActionResult Adduser(User user)
        {
            try
            {
                _userRepository.AddUser(user);
                return Ok(user);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("DeleteUser")]
        public IActionResult Deleteuser(User user)
        {
            try
            {
                _userRepository.Delete(user);
                return Ok("deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetAllUser")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_userRepository.GetAll().ToList());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut,Route("UpdateUser")]
        public IActionResult Update(User user)
        {
            try
            {
               _userRepository.Update(user);
                return Ok("updated");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
