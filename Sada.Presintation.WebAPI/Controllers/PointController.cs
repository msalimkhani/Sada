using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sada.Core.Application.Interfaces;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;

namespace Sada.Presintation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PointController(INomreService nomreService, IKarnameService karnameService) : ControllerBase
    {
        [HttpGet("getAllLessons/{gid}")]
        public async Task<IActionResult> GetAllLessons(int gid)
        {
            return Ok(await nomreService.RetriveLessons(gid));
        }
        
        [HttpGet("getStudentPoints/{stid}")]
        public async Task<IActionResult> GetStudentPoints(int stid)
        {
            return Ok(await nomreService.GetPoints(stid));
        }
        [HttpGet("getStudentPointByLessonId/{stid}/{lid}")]
        public async Task<IActionResult> GetStudentPointById(int stid, int lid)
        {
            return Ok(await nomreService.GetPoint(stid, lid));
        }
        [HttpPost("postPointByLessonId{lid}/{stid}/{point}")]
        public async Task<IActionResult> PostPointByLessonId(int lid, int stid, int point)
        {
            if(lid >0 && stid > 0)
            {
                await nomreService.RegisterNomreForStudentByLessonId(stid, lid, point);
                return Ok();
            }
            else {
                return BadRequest();
            }
        }
        [HttpDelete("removeNomre/{lpid}")]
        public async Task<IActionResult> RemovePoint(int lpid)
        {
            await nomreService.RemoveNomreByLessonPointId(lpid);
            return Ok();
        }
        [HttpGet("generateKarnameByStudentId{stid}")]
        public IActionResult GenerateKarnameByStudentId(int stid)
        {
            return Ok(karnameService.GenerateKarnameByStudentId(stid));
        }
    }
}
