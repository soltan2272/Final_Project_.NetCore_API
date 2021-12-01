using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
   public class SignUpModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Full_Name { set; get; }

        [Required(ErrorMessage = "Adrress is required")]
        public string Adrress { set; get; }

        [Required(ErrorMessage = "Phone is required")]
        public int Phone { set; get; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { set; get; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { set; get; }

        [Required(ErrorMessage = "SSN is required")]
        public int SSN { set; get; }

        [Required(ErrorMessage = "Date Of Birth is required")]
        public DateTime Date_Of_Birth { set; get; }
    }

    public static class SignUpModelExtensions
    {
        public static User SignupToModel(this SignUpModel signUpModel)
        {
            return new User
            {
               Full_Name=signUpModel.Full_Name,
               Adrress=signUpModel.Adrress,
               Phone=signUpModel.Phone,
               SSN=signUpModel.SSN,
               Date_Of_Birth=signUpModel.Date_Of_Birth,
               UserName = signUpModel.Full_Name,
               Email = signUpModel.Email
            };
        }
    }
}
