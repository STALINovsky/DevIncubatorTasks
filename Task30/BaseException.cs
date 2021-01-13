using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Task30
{
    /// <summary>
    /// Base class for custom exception
    /// </summary>
    [Serializable]
    public abstract class BaseException : Exception
    {
        protected BaseException()
        {
        }

        protected BaseException(string message) : base(message)
        {
        }

        protected BaseException(string message, Exception inner) : base(message, inner)
        {
        }

        protected BaseException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
