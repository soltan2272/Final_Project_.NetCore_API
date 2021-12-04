using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reposotries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels;

namespace Final_Project.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
     
        IUserRepository UserRepository;
        public UserController(IUserRepository userRepository, IUnitOfWork unitOfWork)
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

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            string Token = await UserRepository.Login(loginModel);
            if (string.IsNullOrEmpty(Token))
                return Unauthorized();
            return Ok(Token);

        }
    }
}
