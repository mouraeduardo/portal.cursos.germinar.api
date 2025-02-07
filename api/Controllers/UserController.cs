using Microsoft.AspNetCore.Mvc;
using Core.Models.DTOs;
using Core.Services;
namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService; 
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserLoginDTO userLoginDTO)
        {
            try
            {
                bool login = _userService.Login(userLoginDTO);  //_userRepository.GetAllUsers();

                if (login)
                    return Ok("DEU BOM!");
                else return BadRequest("Credencias invalidas!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertUser([FromBody] UserCreateDTO userCreateDTO)
        {
            try
            {
                _userService.CreateUser(userCreateDTO);

                return Ok(userCreateDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
