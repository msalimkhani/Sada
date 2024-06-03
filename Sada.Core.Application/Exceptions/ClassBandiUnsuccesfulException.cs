using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.Exceptions
{
    public class ClassBandiUnsuccesfulException : Exception
    {
        public ClassBandiUnsuccesfulException()
        {
            
        }
        public ClassBandiUnsuccesfulException(string message) : base(message) { }
        public ClassBandiUnsuccesfulException(string message, Exception? inner) : base(message, inner) { }
    }
}
