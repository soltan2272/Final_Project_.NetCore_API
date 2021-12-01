using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Reposotries
{
    public class UserRepository:IUserRepository
    {
        private readonly UserManager<User> UserManager;
        private readonly RoleManager<IdentityRole> RoleManager;
        private  IConfiguration Configuration { get; }
        public UserRepository(UserManager<User> userManager,IConfiguration 
            configuration, RoleManager<IdentityRole> roleManager)
        {
            UserManager = userManager;
            Configuration = configuration;
            RoleManager = roleManager;
        }

        public async Task<string> SignUp(SignUpModel signUpModel)
        {
            User Temp = signUpModel.SignupToModel();
            var result = await UserManager.CreateAsync(Temp, signUpModel.Password);
            if (!result.Succeeded)
                return null;

            var userRoles = await UserManager.GetRolesAsync(Temp);

            var SigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]));

            var UserClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,signUpModel.Full_Name),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

            };

            foreach (var userRole in userRoles)
            {
                UserClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }
            var Token = new JwtSecurityToken
                (
                    issuer: Configuration["JWT:ValidIssuer"],
                    audience: Configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(14),
                    signingCredentials:
                    new SigningCredentials(SigninKey, SecurityAlgorithms.HmacSha256Signature),
                    claims: UserClaims
                );

            return new JwtSecurityTokenHandler().WriteToken(Token);

        }
    }
}
