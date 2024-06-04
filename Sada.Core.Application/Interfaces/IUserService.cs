using Sada.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(User user);
        Task<User?> FindByEmailAsync(string email);
    }
}
