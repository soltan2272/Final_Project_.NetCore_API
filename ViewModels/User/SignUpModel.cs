using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SignUpModel
    {
        public string Full_Name { set; get; }
        public string Adrress { set; get; }
        public int Phone { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public int SSN { set; get; }
        public string Date_Of_Birth { set; get; }
      
    }
    public static class SignUpModelExtensions
    {
        public static User ToModel(this SignUpModel signUpModel)
        {
            return new User
            {
              Full_Name=signUpModel.Full_Name,
              UserName=signUpModel.Full_Name,
              Phone=signUpModel.Phone,
              Adrress=signUpModel.Adrress,
              SSN=signUpModel.SSN,
              Date_Of_Birth=signUpModel.Date_Of_Birth,
              Email = signUpModel.Email
            };
        }
    }
}
