using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PropertyTypeCodesController : ControllerBase
    {
        public IRepository<PropertyTypeCode> Repository { get; }
        public IMapper Mapper { get; }

        public PropertyTypeCodesController(IRepository<PropertyTypeCode> repository, IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }

        
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await Repository.ListAsync();
            return Ok(result);
        }

        // GET api/<PropertyTypeCodesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await Repository.GetByIdAsync(id);

            return result == null
                ? (ActionResult)NotFound()
                : Ok(result);
        }

        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

    }
}
