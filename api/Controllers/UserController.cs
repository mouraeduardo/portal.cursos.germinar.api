using Microsoft.AspNetCore.Mvc;
using Core.Models.DTOs;
using Core.Services;
using Core.Resources.Messages;
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
                if (!ModelState.IsValid) return BadRequest(ModelState);

                bool login = _userService.Login(userLoginDTO);

                if (login) return Ok("DEU BOM!"); // Retornara o token JWT para acessar os demais endpoints
                else return BadRequest(InfoMessages.INF001);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] UserCreateDTO userCreateDTO)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                _userService.CreateUser(userCreateDTO);

                return Ok(SuccessMessages.SUCESS002);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
