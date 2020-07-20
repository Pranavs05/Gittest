using System;
using System.Collections.Generic;

namespace CleanArchitecture.Core.Entities
{
    public partial class AssetCategory
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual Asset Asset { get; set; }
    }
}
