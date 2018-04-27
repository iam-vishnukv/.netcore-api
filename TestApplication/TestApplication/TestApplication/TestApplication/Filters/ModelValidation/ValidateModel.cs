using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ComponentModel.DataAnnotations;

using System.Reflection;
using TestApplication.Filters.ModelValidation;

namespace TestApplication.Filters
{
    public class ValidateModel : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Result = new ValidationFailedResult(actionContext.ModelState);
            }
        }
    }
}

