using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sada.Core.Application.Interfaces;
using Sada.Core.Domain.Entities;
using Sada.Presintation.WebAPI.Models;

namespace Sada.Presintation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClassController(IClassBandiService classBandiService) : ControllerBase
    {
        [HttpPost("CreateClassByGradeId{gid}")]
        public async Task<IActionResult> CreateClassByGradeId(int gid, [FromBody] ClassPostRequest request)
        {
            if (request == null || gid == 0)
            {
                return BadRequest("Request is Empty!.");
            }
            try
            {
                await classBandiService.CreateClassAsync(new SchoolClass()
                {
                    ClassName = request.ClassName,
                    GradeId = gid
                });
                return Ok(request);
            }
            catch
            {
                return BadRequest(request);
            }
        }
        [HttpPut("ModifyClassByGradeId{gid}WithClassId{id}")]
        public async Task<IActionResult> ModifyClassByGradeId(int gid, int id, [FromBody] ClassPutRequest request)
        {
            if (request == null || gid == 0 || id == 0)
            {
                return BadRequest("Request is Empty!.");
            }
            if (request.ClassId != id)
            {
                return BadRequest(request);
            }
            try
            {

                await classBandiService.UpdateClassAsync(new SchoolClass()
                {
                    ClassId = request.ClassId,
                    ClassName = request.ClassName,
                    GradeId = gid
                });
                return Ok(request);
            }
            catch
            {
                return BadRequest(request);
            }
        }
        [HttpDelete("DeleteClassByGradeId{gid}AndClassId{id}")]
        public async Task<IActionResult> DeleteClassByGradeId(int id, int gid)
        {
            if (id == 0 || gid == 0)
            { return BadRequest("Request is Empty!."); }
            var clazz = await classBandiService.GetClassById(id);
            if (clazz == null)
                return NotFound();
            if (clazz.GradeId != gid)
                return BadRequest();
            try
            {
                await classBandiService.DeleteClassAsync(id);
                return Ok();
            }
            catch 
            {
                return BadRequest();
            }
        }
        [HttpPost("RegisterStudent{studentId}ForClassById{classId}")]
        public async Task<IActionResult> RegisterStudentForClassById(int classId, int studentId)
        {
            return Ok(await classBandiService.RegisterStudentForClassAsync(classId, studentId));
        }
        [HttpDelete("RemoveStudent{studentId}ForClassById{classId}")]
        public async Task<IActionResult> RemoveStudentStudentForClassById(int classId, int studentId)
        {
            var res = await classBandiService.RemoveStudentForClassAsync(classId, studentId);
            return (res) ? Ok() : BadRequest();
        }
        [HttpPost("CreateClassCapacity{classId}/{capacity}")]
        public IActionResult CreateClassCapacity(int classId, int capacity)
        {
            classBandiService.CreateClassStudentCapacity(classId, capacity);
            return Ok();
        }
    }
}
