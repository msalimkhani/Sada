using Sada.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
