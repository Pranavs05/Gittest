using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Web.ApiModels.Errors
{
    public class ApiError
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
