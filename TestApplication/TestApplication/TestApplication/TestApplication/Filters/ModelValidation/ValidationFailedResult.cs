using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Response;
using static TestApplication.Response.ValidationErrorResponse;

namespace TestApplication.Filters.ModelValidation
{
    public class ValidationFailedResult: ObjectResult
    {
        public ValidationFailedResult(ModelStateDictionary modelState)
        : base(new ResponseMessage(modelState))
        {
            StatusCode = StatusCodes.Status400BadRequest;
        }
    }
}
