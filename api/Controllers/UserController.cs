using Microsoft.AspNetCore.Mvc;
using Core.Models.DTOs;
using Core.Services;
using Core.Resources.Messages;
using Microsoft.AspNetCore.Authorization;
using Core.Models;
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

                string token = _userService.Login(userLoginDTO);

                if (token is null) return BadRequest(InfoMessages.INF001); // Retornara o token JWT para acessar os demais endpoints

                return Ok("DEU BOM! || Token: " + token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateUser"), Authorize]
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

        [HttpGet("GetAllUsers"), Authorize]
        public IActionResult GetAllUsers()
        {
            try
            {
                List<User> users = _userService.GetAllUsers();

                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
