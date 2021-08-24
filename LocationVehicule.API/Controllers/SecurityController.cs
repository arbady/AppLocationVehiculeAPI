using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ModelClient.Data;
using ModelClient.Services;
using ModelGlobal.Data;
using Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly JWTSettings jwtSettings;
        private readonly IRepoUser<UserClient> security;

        public SecurityController(IOptions<JWTSettings> jwtSettings, IRepoUser<UserClient> security)
        {
            this.security = security;
            this.jwtSettings = jwtSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public ActionResult<UserClient> Login(string email, string password)
        {
            try
            {
                UserClient user = security.Check(email, password);
                if (user is null) return StatusCode(StatusCodes.Status401Unauthorized, "L'email et le mot de passe ne correspondent à aucun profil.");

                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(jwtSettings.SecretKey);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.Email),
                        new Claim(ClaimTypes.Role, user.Role.ToString())
                    }),

                    Expires = DateTime.UtcNow.AddMinutes(10),

                    SigningCredentials = new SigningCredentials
                    (
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature
                    )
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                user.Token = tokenHandler.WriteToken(token);

                return Ok(user.Token);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = nameof(Login),
                    Message = ex.Message
                });
            }
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public ActionResult<string> Register(UserClient user)
        {
            try
            {
                int UserId = security.Post(user);
                
                return Ok("Le compte utilisateur " + user.Email + " a bien été créé.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = nameof(Register),
                    Message = ex.Message
                });
            }
        }
    }
}
