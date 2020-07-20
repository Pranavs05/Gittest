using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Core.Enums
{
    public enum AssetConventionEnum
    {
        [Display(Name="Half Year")]
        HY,
        [Display(Name = "Mid Quarter")]
        MQ,
        [Display(Name = "Mid Month")]
        MM
    }
}
