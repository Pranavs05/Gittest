using System;
using System.Collections.Generic;

namespace CleanArchitecture.Core.Entities
{
    public partial class Asset
    {
        public int Id { get; set; }
        public int AssetNumber { get; set; }
        public string ActivityCategory { get; set; }
        public int AssetCategoryId { get; set; }
        public string Description { get; set; }
        public DateTime DateInService { get; set; }
        public decimal Cost { get; set; }
        public double BusinessPercentage { get; set; }
        public int ListedPropertyTypeId { get; set; }
        public int MethodId { get; set; }
        public double Life { get; set; }
        public decimal? PriorRegDepreciation { get; set; }
        public decimal? PriorBonusDepriciation { get; set; }
        public decimal? PriorExpSec179 { get; set; }
        public int PropertyTypeCodeId { get; set; }
        public int? AmortizationCodeId { get; set; }
        public int ConventionId { get; set; }
        public decimal? CurrentDepriciation { get; set; }
        public decimal? CurrentYearExpSec179 { get; set; }
        public decimal? BonusDepriciation { get; set; }

        public virtual AssetCategory AssetCategory { get; set; }
        public virtual AssetConvention AssetConvention { get; set; }
        public virtual AssetMethodCategory Method { get; set; }
        public virtual ListedPropertyType PropertyType { get; set; }
        public virtual PropertyTypeCode PropertyTypeCode { get; set; }
        public virtual AmortizationCode AmortizationCode { get; set; }
    }
}
