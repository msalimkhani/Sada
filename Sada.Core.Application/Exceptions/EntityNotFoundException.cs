using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.Exceptions
{
    public class EntityNotFoundException<TModel> : Exception where TModel : class
    {
        public EntityNotFoundException() 
        {
            Console.Error.WriteLine("Entity " + typeof(TModel) + " Not Found!");
        }
        public EntityNotFoundException(string message) : base("Entity " + typeof(TModel) + " Not Found!" + "Message : " + message)
        {
        }
        public EntityNotFoundException(string message, Exception? inner) : base("Entity " + typeof(TModel) + " Not Found!" + "Message : " + message, inner) { }
    }
}
