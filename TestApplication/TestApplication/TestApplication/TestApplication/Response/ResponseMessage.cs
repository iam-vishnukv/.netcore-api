using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using static TestApplication.Response.ValidationErrorResponse;

namespace TestApplication.Response
{
    public class ResponseMessage
    {
        private const string ErrorStatus = "Error";
        private const string SucessStatus = "Sucess";
        private const string validationError = "Validation Failed";
        private const string InternalServerError = "Internal Server Error";
       // private const string InternalServerError = "Internal Server Error";

        public string Status { get; }
        public string Message { get; }
        public List<Object> dataObject { get;  }
        public List<Object> errorList { get; }


        public ResponseMessage(ModelStateDictionary modelState)
        {
            Status = ErrorStatus;
            Message = validationError;
            var errors = modelState.Keys
                        .SelectMany(key => modelState[key].Errors.Select(x => new ValidationError(key, x.ErrorMessage)))
                        .ToList();
            errorList = errors.ToList<Object>();

        }

        public ResponseMessage(Exception ex)
        {
            Status = ErrorStatus;
            Message = InternalServerError;
            var error = new ResponseErrorMessage(ex.Message);
            errorList = new List<object>
            {
                error
            };
        }


        public ResponseMessage(ResponseType resultType,object data)
        {
            Status = SucessStatus;
            Message = InternalServerError;
            dataObject = new List<object>
            {
                data
            };
        }


    

    }


  public  enum ResponseType
    {
        Sucess,
        ResultEmpty,
        Failed

    }

 
}
