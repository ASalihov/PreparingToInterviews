using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Diagnostics.Contracts;


namespace PreparingToInterviews
{
    public class Exception<TExceptionArgs> : Exception, ISerializable
        where TExceptionArgs : ExceptionArgs
    {
        private const string c_args = "Args";
        private readonly TExceptionArgs m_args;

        public Exception(string Message = null, Exception innerException = null)
            : this(null, Message, innerException)
        {

        }

        public Exception(TExceptionArgs args, string Message = null, Exception innerException = null)
            : base(Message, innerException)
        {
            m_args = args;
        }

        // Ctor for deserialization
        private Exception(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            m_args = (TExceptionArgs)info.GetValue(c_args, typeof(TExceptionArgs));
        }

        // Method for serialization
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(c_args, m_args);
            base.GetObjectData(info, context);
        }

        public override string Message
        {
            get
            {
                string baseMsg = base.Message;
                return (m_args == null) ? baseMsg : baseMsg + " (" + m_args.Message + ")";
            }
        }

    }
    
    public abstract class ExceptionArgs
    {
        public virtual string Message { get { return string.Empty; } }
    }

    public class MyClass
    {
        public int MyProperty { get; set; }
        
        
    }
}
