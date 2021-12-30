using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearningApp.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : this("Validation Error Occurred")
        {

        }

        public ValidationException(string Message) : base(Message)
        {

        }
        public ValidationException(Exception ex) : this(ex.Message)
        {

        }
    }
}
