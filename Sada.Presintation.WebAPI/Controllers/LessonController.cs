using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using Sada.Presintation.WebAPI.Models;

namespace Sada.Presintation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LessonController(IRepository<Lesson> lessonRepository) : ControllerBase
    {
        [HttpGet("GetLessonsByGrade{gid}")]
        public async Task<IActionResult> GetLessons(int gid) 
            => Ok(await lessonRepository.Where(l=>l.GradeId == gid).ToListAsync());
        [HttpGet("GetLessonByGrade{gid}/id={id}")]
        public async Task<IActionResult> GetLessonById(int gid, int id)
            => Ok(await lessonRepository.Where(l => l.GradeId == gid && l.LessonId == id).FirstOrDefaultAsync());
        [HttpPost("PostLessonByGrade{gid}")]
        public async Task<IActionResult> PostLesson(int gid, [FromBody] LessonPostRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            lessonRepository.Add(new Lesson()
            {
                GradeId = gid,
                LessonName = request.LessonName
            });
            try
            {
                await lessonRepository.SaveChangesAsync();
                return Ok(request);
            }
            catch
            {
                return BadRequest(request);
            }
        }
        [HttpPut("PutLessonByGrade{gid}WithId{id}")]
        public async Task<IActionResult> PutLesson(int gid, int id, [FromBody] LessonPutRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if(!(id != 0 && gid != 0 && request.LessonId == id && request.GradeId == gid))
            {
                return BadRequest(request);
            }
            lessonRepository.Update(new Lesson()
            {
                LessonId = id,
                GradeId = gid,
                LessonName = request.LessonName
            });
            try
            {
                await lessonRepository.SaveChangesAsync();
                return Ok(request);
            }
            catch
            {
                return BadRequest(request);
            }
        }
        [HttpDelete("DeleteLessonByGrade{gid}WithId{id}")]
        public async Task<IActionResult> DeleteLesson(int gid, int id)
        {
            var lesson = await lessonRepository.FindByIdAsync(id);
            if (!(lesson != null && lesson.GradeId == gid))
                return NotFound();
            else
            {
                lessonRepository.Delete(lesson);
            }
            try
            {
                await lessonRepository.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
