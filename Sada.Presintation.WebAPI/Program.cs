
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Sada.Core.Application.Interfaces;
using Sada.Core.Application.Repositories;
using Sada.Core.Domain.Entities;
using Sada.Infrastructure.Data;
using Sada.Infrastructure.Services;
using System.Text;

namespace Sada.Presintation.WebAPI
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ServiceRegistry registry = ServiceRegistry.GetRegistry(builder.Services, builder.Configuration);
            registry.RegisterDbContext();
            registry.RegsiterServices();
            registry.ConfigEndpoint();
            registry.RegisterRepositories();
            registry.Dispose();
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
