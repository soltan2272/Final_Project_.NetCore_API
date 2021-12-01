using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
   public class LoginModel
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }

    public static class LoginExtensions
    {
        public static User LoginToModel(this LoginModel signUpModel)
        {
            return new User
            {
                Email = signUpModel.Email
            };
        }
    }
}
