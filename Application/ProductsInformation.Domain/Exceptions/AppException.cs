using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Exceptions
{
    [System.Serializable]
    public class AppException : System.Exception
    {
        public AppException() { }
        public AppException(string message) : base(message) { }
        public AppException(string message, System.Exception inner) : base(message, inner) { }
        protected AppException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
