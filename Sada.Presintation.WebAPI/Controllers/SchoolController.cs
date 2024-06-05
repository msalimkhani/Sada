using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;

namespace Sada.Presintation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController(IRepository<School> repository) : ControllerBase
    {

    }
}
