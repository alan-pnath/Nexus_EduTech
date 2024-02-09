using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NexusEduTech_BackEnd.Repository;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordRecoveryController : ControllerBase
    {
        private readonly PasswordRecoveryRepository _passwordRecoveryRepository;

        public PasswordRecoveryController(PasswordRecoveryRepository passwordRecoveryRepository)
        {
            _passwordRecoveryRepository = passwordRecoveryRepository;
        }
        [HttpPut,Route("Verify/{email}/{newpass}/{Confirmpass}")]
        public IActionResult Verify(string email, string newpass, string Confirmpass)
            {
            try
            {
                var result=_passwordRecoveryRepository.verify(email, newpass, Confirmpass);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
