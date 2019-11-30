using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cities.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : BaseController
    {
        // GET: api/Country
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await ServiceWrapper.CountryService.GetList();
            return Ok(list);
        }
    }
}