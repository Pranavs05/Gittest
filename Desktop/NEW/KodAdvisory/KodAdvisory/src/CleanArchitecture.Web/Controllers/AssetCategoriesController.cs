﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AssetCategoriesController : ControllerBase
    {
        public IRepository<AssetCategory> Repository { get; }
        public IMapper Mapper { get; }

        public AssetCategoriesController(IRepository<AssetCategory> repository, IMapper mapper)
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

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await Repository.GetByIdAsync(id);

            return result == null
                ? (ActionResult)NotFound()
                : Ok(result);
        }
    }
}
