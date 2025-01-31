using BaseLibrary.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerLibarry.Repositories.Contracts;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchtController(IGenericRepositoryInterface<Branch> genericRepositoryInterface)
        : GenericController<Branch>(genericRepositoryInterface)
    {
    }
}
