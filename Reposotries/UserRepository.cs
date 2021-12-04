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
    public class UserRepository : IUserRepository
    {
        UserManager<User> UserManager;
       // RoleManager<User> RoleManager;
        public IConfiguration Configuration { get; }
        public UserRepository(UserManager<User> userManager,
            IConfiguration configuration)
        {
            UserManager = userManager;
            Configuration = configuration;
        }


        public async Task<string> SignUp(SignUpModel signUpModel)
        {
            User Temp = signUpModel.ToModel();
            var result = await UserManager.CreateAsync(Temp, signUpModel.Password);
            if (!result.Succeeded)
                return null;

          /*  var userRoles = await UserManager.GetRolesAsync(Temp);*/


            var SigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]));

            var UserClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,signUpModel.Full_Name),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

            };

         /*   foreach (var userRole in userRoles)
            {
                UserClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }*/


            var Token = new JwtSecurityToken
                (
                    issuer: Configuration["JWT:ValidIssuer"],
                    audience: Configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(14),
                    signingCredentials: new SigningCredentials(SigninKey, SecurityAlgorithms.HmacSha256Signature),
                    claims: UserClaims
                );


         /*   if (!await RoleManager.RoleExistsAsync(UserRoles.Seller))
                await RoleManager.CreateAsync(new IdentityRole(UserRoles.Seller));
            if (!await RoleManager.RoleExistsAsync(UserRoles.User))
                await RoleManager.CreateAsync(new IdentityRole(UserRoles.User));*/

            return new JwtSecurityTokenHandler().WriteToken(Token);

        }
        public async Task<string> Login(LoginModel model)
        {
            var user = await UserManager.FindByEmailAsync(model.Email);
            if (user != null && await UserManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await UserManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                   issuer: Configuration["JWT:ValidIssuer"],
                    audience: Configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                   signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256Signature)
                    );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            return null;
        }
    }
}
