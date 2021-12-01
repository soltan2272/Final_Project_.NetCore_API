using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reposotries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository UserRepository;
        public UserController(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }




        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(SignUpModel signupModel)
        {
            string Token = await UserRepository.SignUp(signupModel);
            if (string.IsNullOrEmpty(Token))
                return Unauthorized();
            return Ok(Token);

        }
    }
}
