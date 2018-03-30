using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace TestProject.Service.Exception
{   [Serializable]
    class ServerException: ApplicationException
    {

        public ServerException(): base()
        {
        }

        public ServerException(string Message): base(Message)
        {
        }

        public ServerException(string Message,ApplicationException InnerException): base(Message, InnerException)
        {
        }

        protected ServerException(SerializationInfo Info,StreamingContext Context): base(Info, Context)
        {
        }
    }
}
