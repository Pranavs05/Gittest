using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Web.ApiModels.Asset;
using CleanArchitecture.Web.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        public IAssetRepository AssetRepository { get; }
        public IMapper Mapper { get; }

        public AssetsController(IAssetRepository assetRepository, IMapper mapper)
        {
            AssetRepository = assetRepository;
            Mapper = mapper;
        }

        /// <summary>
        /// Get all assets
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var assets = AssetRepository.Get(x => x.Id > 0);
            return Ok(Mapper.Map<IEnumerable<AssetResponse>>(assets));
        }

        /// <summary>
        /// Get asset by ID
        /// </summary>
        /// <param name="assetId"></param>
        /// <returns></returns>
        [HttpGet("{assetId}", Name = nameof(AssetsController.GetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AssetResponse>> GetByIdAsync(int assetId)
        {
            Core.Entities.Asset asset = await AssetRepository.GetByIdAsync(assetId);

            return asset == null 
                ? (ActionResult)NotFound()
                : Ok(Mapper.Map<AssetResponse>(asset));
        }

        /// <summary>
        /// Create new asset
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateModel]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> Post([FromBody] NewAssetRequest asset)
        {
            Asset result = await AssetRepository.AddAsync(Mapper.Map<Asset>(asset));

            return CreatedAtRoute(nameof(AssetsController.GetByIdAsync), new { id = result.Id }, result);
        }

        /// <summary>
        /// Update existing asset
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="assetUpdate"></param>
        /// <returns></returns>
        [HttpPut("{assetId}")]
        [ValidateModel]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> Put(int assetId, [FromBody] AssetUpdateRequest assetUpdate)
        {
            var existingAsset = await AssetRepository.GetByIdAsync(assetId);
            if (existingAsset == null)
            {
                return NotFound($"Asset with id {assetId} not found");
            }

            await AssetRepository.UpdateAsync(Mapper.Map<Asset>(assetUpdate));

            return NoContent();
        }

        /// <summary>
        /// Remove asset
        /// </summary>
        /// <param name="assetId"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("{assetId}")]
        public async Task<ActionResult> Delete(int assetId)
        {
            var asset = await AssetRepository.GetByIdAsync(assetId);
            if(asset == null)
            {
                return NotFound($"Asset with id {assetId} not found");
            }

            await AssetRepository.DeleteAsync(asset);

            return NoContent();
        }
    }
}
