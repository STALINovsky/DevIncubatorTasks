using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Task30
{
    /// <summary>
    /// The exception that is thrown when object not exist
    /// </summary>
    [Serializable]
    public class ObjectNotExistException : BaseException
    {
        public ObjectNotExistException()
        {
        }

        public ObjectNotExistException(string message) : base(message)
        {
        }

        public ObjectNotExistException(string message, Exception inner) : base(message, inner)
        {
        }

        protected ObjectNotExistException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
