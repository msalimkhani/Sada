using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using Sada.Presintation.WebAPI.Models;
using System.Security.Claims;

namespace Sada.Presintation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SchoolController(IRepository<School> repository) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetSchools()
        {
            int userId = 0;
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("No user ID claim present in token.");
            }
            if (!int.TryParse(userIdClaim, out userId))
            {
                return Unauthorized();
            }
            return Ok(await repository.Where(s => s.UserId == userId).ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSchoolById(int id)
        {
            int userId = 0;
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("No user ID claim present in token.");
            }
            if (!int.TryParse(userIdClaim, out userId))
            {
                return Unauthorized();
            }
            var s = await repository.FindByIdAsync(id);
            
            if(s!= null && s.UserId == userId)
            {
                return Ok(s);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> PostSchool([FromBody] SchoolAddRequest request)
        {
            int userId = 0;
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("No user ID claim present in token.");
            }
            if (!int.TryParse(userIdClaim, out userId))
            {
                return Unauthorized();
            }
            try
            {
                repository.Add(new School()
                {
                    Address = request.Address,
                    PhoneNumber = request.PhoneNumber,
                    PostalCode = request.PostalCode,
                    SchoolName = request.SchoolName,
                    UserId = userId
                });
                await repository.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchool([FromBody] SchoolPutRequest request, int id)
        {
            int userId = 0;
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("No user ID claim present in token.");
            }
            if (!int.TryParse(userIdClaim, out userId))
            {
                return Unauthorized();
            }
            var s = await repository.FindByIdAsync(id);
            if(s == null)
            {
                return  NotFound();
            }
            if(s.UserId != userId)
            {
                return Unauthorized("You Have not access.");
            }
            if(id != request.SchoolId)
            {
                return  BadRequest();
            }
            try
            {
                repository.Update(new School() 
                {
                    SchoolId = id,
                    Address = request.Address,
                    PhoneNumber = request.PhoneNumber,
                    PostalCode = request.PostalCode,
                    SchoolName = request.SchoolName
                });
                await repository.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchool(int id)
        {
            int userId = 0;
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("No user ID claim present in token.");
            }
            if (!int.TryParse(userIdClaim, out userId))
            {
                return Unauthorized();
            }
            var s = await repository.FindByIdAsync(id);
            if (s == null)
            {
                return NotFound();
            }
            if (s.UserId != userId)
            {
                return Unauthorized("You Have not access.");
            }
            try
            {
                repository.Delete(id);
                await repository.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
