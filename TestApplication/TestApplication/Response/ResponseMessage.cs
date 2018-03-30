using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static TestApplication.Response.ValidationErrorResponse;

namespace TestApplication
{
    public class ResponseMessage
    {

            public string status { get; }
            public string message { get; }

            public List<Object> dataObject{ get; }
            public List<Object> errorList { get; }
        public ResponseMessage(ModelStateDictionary modelState)
            {
               status = "Error";
                message = "Validation Failed";
                var errors = modelState.Keys
                        .SelectMany(key => modelState[key].Errors.Select(x => new ValidationError(key, x.ErrorMessage)))
                        .ToList();
                 errorList = errors.ToList<Object>();

            }
        }
}
