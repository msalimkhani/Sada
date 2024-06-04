using Microsoft.EntityFrameworkCore;
using Sada.Core.Application.Interfaces;
using Sada.Core.Domain.Entities;
using Sada.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Infrastructure.Services
{
    public class UserService(SadaDbContext sadaDbContext) : IUserService
    {
        public async Task CreateUser(User user)
        {
            sadaDbContext.Users.Add(user);
            await sadaDbContext.SaveChangesAsync();
        }

        public async Task<User?> FindByEmailAsync(string email)
        {
            return await sadaDbContext.Users.Where(u => u.Email == email).FirstOrDefaultAsync();
        }
    }
}
