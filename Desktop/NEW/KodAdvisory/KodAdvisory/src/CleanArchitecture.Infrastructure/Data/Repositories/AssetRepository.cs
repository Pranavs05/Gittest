using CleanArchitecture.Core.Entities;
using CleanArchitecture.Infrastructure.Data.Contexts;
using CleanArchitecture.Infrastructure.Repositories;
using CleanArchitecture.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class AssetRepository : Repository<Asset>, IAssetRepository
    {
        public AssetRepository(KodAdvisoryContext ctx): base(ctx)
        {

        }

        //repo methods go here
    }
}
