using AutoMapper;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Web.ApiModels.Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Web.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<NewAssetRequest, Asset>();
            CreateMap<Asset, AssetResponse>();
            CreateMap<AssetUpdateRequest, Asset>();

        }
    }
}
