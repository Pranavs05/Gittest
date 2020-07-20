﻿using CleanArchitecture.Core;
using System;
using System.Collections.Generic;

namespace CleanArchitecture.Core.Entities
{
    public partial class AmortizationCode
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }

        public virtual Asset Asset { get; set; }
    }
}