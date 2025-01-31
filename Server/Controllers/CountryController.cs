﻿using BaseLibrary.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerLibarry.Repositories.Contracts;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController(IGenericRepositoryInterface<Country> genericRepositoryInterface)
        : GenericController<Country>(genericRepositoryInterface)
    {
    }
}
