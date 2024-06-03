using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.Exceptions
{
    public class StudentRegisterUnsucessfullException : Exception
    {
        public StudentRegisterUnsucessfullException()
        {
            
        }
        public StudentRegisterUnsucessfullException(string message):base(message) { }
        public StudentRegisterUnsucessfullException(string message, Exception? inner): base(message, inner) { }
    }
}
