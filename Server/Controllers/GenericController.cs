using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using ServerLibarry.Repositories.Contracts;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T>(IGenericRepositoryInterface<T> genericRepositoryInterface) : Controller where T : class
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll() => Ok(await genericRepositoryInterface.GetAll());

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest("Invalid request sent");
            return Ok(await genericRepositoryInterface.DeleteById(id));
        }
        
        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0) return BadRequest("Invalid request sent");
            return Ok(await genericRepositoryInterface.GetById(id));
        }
        
        [HttpPost("add")]
        public async Task<IActionResult> Add(T model)
        {
            return Ok(await genericRepositoryInterface.Insert(model));
        }
    }
}
