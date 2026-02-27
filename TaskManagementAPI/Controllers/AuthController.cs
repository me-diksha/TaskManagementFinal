using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using TaskManagementAPI.Services.Interface;
using TaskManagementAPI.Model;

namespace TaskManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;

        }
        // GET: api/<APIAuthController>
        [HttpPost("login")]
        public IActionResult Login([FromBody] TaskManagementAPI.Model.LoginRequest loginuser) {
         var user=_userService.authenticate(loginuser.Username, loginuser.Password);

            if (user == null) { 
            return Unauthorized();
            }
            return Ok(user);
        }

        // GET api/<APIAuthController>/5
       
        [HttpGet("usernameexist/{username}")]
        public IActionResult UsernameExist(string username)
        {
            var exists = _userService.userNameExist(username);

            if (!exists)
                return NotFound();

            return Ok();
        }

      
       

        [HttpPost("adduser")]
        public IActionResult AddUser([FromBody] AddUserRequest request)
        {
            var result = _userService.addNewUser(
                request.Username,
                request.Password,
                request.Role);

            if (!result)
                return BadRequest();

            return Ok();
        }
     

        [HttpPost("changepassword")]
        
        public IActionResult ChangePassword([FromBody] ChangePasswordRequest request)
        {
            var result = _userService.changepassword(
                request.Username,
                request.Password);

            if (!result)
                return BadRequest();

            return Ok();
        }

        [HttpGet("getrole/{id}")]
        public IActionResult GetRole(int id)
        {
            var role = _userService.getrole(id);

            if (role == null)
                return NotFound();

            return Ok(role);
        }

        [HttpGet("getname/{id}")]
        public IActionResult GetInfo(int id)
        {
            var role = _userService.getInfo(id);

            if (role == null)
                return NotFound();

            return Ok(role);
        }

        [HttpGet("getAlluser/{role}")]
        public IActionResult GetAllUsers(string role)
        {
            var users = _userService.getall(role);

            if (users == null || !users.Any())
                return NotFound();

            return Ok(users);
        }
}
        

    }

