
using Microsoft.AspNetCore.Mvc;
using SkillTest.Interfaces;
using SkillTest.Models;

namespace SkillTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost("login")]
        public IActionResult ValidateLogin(Login login)
        {
            return Ok(_loginService.Login(login.UserName, login.Password));
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Ok("Test");
        }
    }
}
