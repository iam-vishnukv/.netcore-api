using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Response
{
    public class ResponseErrorMessage
    {
        public string ErrorMessage { get; }

        public ResponseErrorMessage(string error)
        {
            this.ErrorMessage = error;
        }


    }
}
