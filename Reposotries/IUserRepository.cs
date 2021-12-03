using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Reposotries
{
    public interface IUserRepository
    {
        Task<string> SignUp(SignUpModel signUpModel);

        Task<string> Login(LoginModel loginModel);
    }
}
