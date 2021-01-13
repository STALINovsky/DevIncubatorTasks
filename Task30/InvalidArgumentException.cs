using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Task30
{
    /// <summary>
    /// The exception that is thrown when argument is invalid
    /// </summary>
    [Serializable]
    public class InvalidArgumentException : BaseException
    {

        public InvalidArgumentException()
        {
        }

        public InvalidArgumentException(string message) : base(message)
        {
        }

        public InvalidArgumentException(string message, Exception inner) : base(message, inner)
        {
        }

        protected InvalidArgumentException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
