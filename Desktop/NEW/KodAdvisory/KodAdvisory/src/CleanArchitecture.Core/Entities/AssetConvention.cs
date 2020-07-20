using System;
using System.Collections.Generic;

namespace CleanArchitecture.Core.Entities
{
    public partial class AssetConvention
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Abbr { get; set; }

        public virtual Asset Asset { get; set; }
    }
}
