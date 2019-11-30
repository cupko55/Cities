using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cities.Api.Filters;
using Cities.Contracts.DTOs;
using Cities.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cities.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : BaseController
    {
        // GET: api/City
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await ServiceWrapper.CityService.GetList();
            return Ok(list);
        }

        // GET: api/City/Get/5
        [HttpGet("{id}", Name = "Get")]
        [ServiceFilter(typeof(ValidateEntityExistsAttribute<City>))]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await ServiceWrapper.CityService.Get(id);
            return Ok(entity);
        }

        // POST: api/City
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Post([FromBody] CityDto model)
        {
            await ServiceWrapper.CityService.Create(model);
            return CreatedAtAction("Post", model);
        }

        // PUT: api/City/5
        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidateEntityExistsAttribute<City>))]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Put(int id, [FromBody] CityDto model)
        {
            var entity = HttpContext.Items["entity"] as City;
            await ServiceWrapper.CityService.Update(model, entity);
            return Ok(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateEntityExistsAttribute<City>))]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = HttpContext.Items["entity"] as City;
            await ServiceWrapper.CityService.Delete(entity);
            return Ok(entity);
        }
    }
}
