using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using Sada.Presintation.WebAPI.Models;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Sada.Presintation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GradeController(IRepository<Grade> repository, IRepository<School> schoolRepo) : ControllerBase
    {
        [HttpGet("school{sid}")]
        public async Task<IActionResult> GetGrades(int sid)
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
            var s = await schoolRepo.FindByIdAsync(sid);
            if(s is not null && s.UserId == userId)
            {
                return Ok(await repository.Where(s => s.SchoolId == sid).ToListAsync());
            }
            return Unauthorized() ;
        }
        [HttpGet("school{sid}/{id}")]
        public async Task<IActionResult> GetGradeById(int sid, int id)
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
            var s = await schoolRepo.FindByIdAsync(sid);
            if (s is not null && s.UserId == userId)
            {
                var g = await repository.FindByIdAsync(id);

                if (s != null && s.SchoolId == sid)
                {
                    return Ok(s);
                }
                return NotFound();
            }
            return Unauthorized();
            
        }
        [HttpPost("school{sid}")]
        public async Task<IActionResult> PostGrade(int sid, [FromBody] GradeAddRequest request)
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
            var s = await schoolRepo.FindByIdAsync(sid);
            if (s is not null && s.UserId == userId)
            {
                try
                {
                    repository.Add(new Grade()
                    {
                        GradeName = request.GradeName,
                        SchoolId = sid
                    });
                    await repository.SaveChangesAsync();
                    return Ok();
                }
                catch
                {
                    return BadRequest();
                }
            }
            return Unauthorized();
        }
        [HttpPut("schoole{sid}/{id}")]
        public async Task<IActionResult> PutGrade([FromBody] GradePutRequest request, int id, int sid)
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
            var s = await schoolRepo.FindByIdAsync(sid);
            if (s is not null && s.UserId == userId)
            {
                if (request.GradeId != id)
                    return NotFound();
                try
                {
                    repository.Update(new Grade()
                    {
                        GradeName = request.GradeName,
                        SchoolId = sid,
                        GradeId = id
                    });
                    await repository.SaveChangesAsync();
                    return Ok();
                }
                catch
                {
                    return BadRequest();
                }
            }
            return Unauthorized();
            
        }
        [HttpDelete("school{sid}/{id}")]
        public async Task<IActionResult> DeleteGrade(int id, int sid)
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
            var s = await schoolRepo.FindByIdAsync(sid);
            if (s is not null && s.UserId == userId)
            {
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
            return Unauthorized();
        }
    }
}
