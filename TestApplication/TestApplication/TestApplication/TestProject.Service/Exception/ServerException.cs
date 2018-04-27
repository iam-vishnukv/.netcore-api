using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace TestProject.Infrastrure.Exception
{   [Serializable]
  public  class ServerException: ApplicationException
    {

        public ServerException(): base()
        {
        }

        public ServerException(string Message): base(Message)
        {
            //return Message;
        }

        public ServerException(string Message,System.Exception InnerException): base(Message, InnerException)
        {
            throw InnerException;
        }

        protected ServerException(SerializationInfo Info,StreamingContext Context): base(Info, Context)
        {
        }
    }
}
