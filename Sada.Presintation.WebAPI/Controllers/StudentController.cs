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
    public class StudentController(ISabtNamService sabtNamService) : ControllerBase
    {
        [HttpPost("RegisterStudent")]
        public async Task<IActionResult> RegisterStudent([FromBody] StudentRegisterRequest request)
        {
            if (request == null) return BadRequest("Request is Empty!.");

            try
            {
                await sabtNamService.RegisterStudentAsync(new Student()
                {
                    Address = request.Address,
                    BirthDate = request.BirthDate,
                    FatherName = request.FatherName,
                    Name = request.Name,
                    NationalCode = request.NationalCode,
                    PhoneNumber = request.PhoneNumber,
                    PostalCode = request.PostalCode,
                    Serial = request.Serial,
                });
                return Ok(request);
            }
            catch 
            {
                return BadRequest(request);
            }
        }
        [HttpPut("ModifyStudentById={stId}")]
        public async Task<IActionResult> ModifyStudent(int stId, [FromBody] StudentModifyRequest request)
        {
            if(request == null || request.StudentId != stId)
            {
                return NotFound(request);
            }
            try
            {
                await sabtNamService.Edit(new Student()
                {
                    Address = request.Address,
                    BirthDate = request.BirthDate,
                    FatherName = request.FatherName,
                    Name = request.Name,
                    NationalCode = request.NationalCode,
                    PhoneNumber = request.PhoneNumber,
                    PostalCode = request.PostalCode,
                    Serial = request.Serial,
                    StudentId = request.StudentId
                });
                return Ok(request);
            }
            catch
            {
                return BadRequest(request);
            }
        }
        [HttpDelete("DeleteStudentById={stId}")]
        public async Task<IActionResult> DeleteStudent(int stId)
        {
            try
            {
                await sabtNamService.Delete(stId);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
