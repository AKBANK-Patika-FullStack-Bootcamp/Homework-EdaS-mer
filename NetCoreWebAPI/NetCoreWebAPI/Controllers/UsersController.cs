using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        List<User> users = new List<User>()
        {
            new User{ID=1,UserName="user1",Password="123"},
            new User{ID=2,UserName="user2",Password="123"},
        };

        [HttpPost]
        public IActionResult Authenticate(User user)
        {
            var authenticateUser = users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("bilge adam akademi");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
           {
                    new Claim(ClaimTypes.Name, user.ID.ToString())
           }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);
            user.Password = null;

            return Ok(user);
        }

          
    }
}
