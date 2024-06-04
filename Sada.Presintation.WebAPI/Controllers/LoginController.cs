using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Sada.Core.Application.Interfaces;
using Sada.Core.Domain.Entities;
using Sada.Infrastructure.Services;
using Sada.Presintation.WebAPI.Auth;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Sada.Presintation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController(PasswordHasher<User> _passwordHasher, ITokenService tokenService, IUserService userService) : Controller
    {
        private string GenerateSalt()
        {
            var chars = "asdfghjklqwertyuiopzxcvbnmASDFGHJKLZXCVBNMQWERTYUIOP";
            var rnd = new Random();
            string res = "";
            for (int i = 0; i< 5; i++)
            {
                res += chars[rnd.Next(77)];
            }
            return res;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var salt = GenerateSalt();
            var saltedPassword = request.Password + salt;

            var user = new User
            {
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                DisplayName = request.Username,
                Email = request.Email,
                Password = _passwordHasher.HashPassword(null, saltedPassword),    // Null is because the user is not created yet, normally this is where the user object is.
                Salt = salt
            };

            await userService.CreateUser(user);
            var token = tokenService.CreateToken(user);

            return Ok(new AuthResponse { Token = token });
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            User? user = await userService.FindByEmailAsync(request.Email);

            if (user == null)
            {
                return Unauthorized("Invalid credentials 1");
            }

            var saltedPassword = request.Password + user.Salt;

            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, saltedPassword);

            if (result != PasswordVerificationResult.Success)
            {
                return Unauthorized("Invalid credentials 2");
            }

            // Generate token
            var token = tokenService.CreateToken(user);

            // Return the token
            return Ok(new AuthResponse { Token = token });
        }
    }
}
