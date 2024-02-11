using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NexusEduTech_BackEnd.Models;
using NexusEduTech_BackEnd.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NexusEduTech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        private readonly IConfiguration configuration;

        public UserController(UserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            this.configuration = configuration;
        }

        [HttpPost, Route("AddUser")]
        [AllowAnonymous]
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

        [HttpPost, Route("Login")]
        [AllowAnonymous]
        public IActionResult Validate(LoginUser login)
        {
            try
            {
                User user = _userRepository.validate(login);
                AuthResponse response = new AuthResponse();

                if (user != null)
                {
                    response.Username = user.UserName;
                    response.Role = user.Role;
                    response.Token = GetToken(user);
                }
                return StatusCode(200, response);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        private string GetToken(User? user)
        {
            var issuer = configuration["Jwt:Issuer"];
            var audience = configuration["Jwt:Audience"];
            var key = Encoding.UTF8.GetBytes(configuration["Jwt:Key"]);
            //header part
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature
            );
            //payload part
            var subject = new ClaimsIdentity(new[]
            {
                    /*new Claim(ClaimTypes.id,user.Id),*/
                    new Claim(ClaimTypes.Name,user.UserName),
                    new Claim(ClaimTypes.Role, user.Role),
                    new Claim(ClaimTypes.Email,user.Email),
                });

            var expires = DateTime.UtcNow.AddMinutes(10);
            //signature part
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = subject,
                Expires = expires,
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = signingCredentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            return jwtToken;
        }

        [HttpDelete, Route("DeleteUser")]
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
        [HttpGet, Route("GetAllUser")]
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
        [HttpPut, Route("UpdateUser")]
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

