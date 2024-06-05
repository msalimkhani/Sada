using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Sada.Core.Application.Interfaces;
using Sada.Core.Domain.Entities;
using Sada.Infrastructure.Data;
using Sada.Infrastructure.Services;
using System.Text;

namespace Sada.Presintation.WebAPI
{
    public class ServicesRegistry(IServiceCollection services, ConfigurationManager configuration)
    {
        public void Register()
        {
            services.AddScoped<IClassBandiService, ClassBandiService>();
            services.AddScoped<IKarnameService, KarnameService>();
            services.AddScoped<INomreService, NomreService>();
            services.AddScoped<ISabtNamService, SabtNamService>();
            services.AddDbContext<SadaDbContext>(options => options.UseSqlServer("Name=ConnectionStrings:SadaConnectionString"));
            services.AddScoped<PasswordHasher<User>>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserService, UserService>();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
                    ClockSkew = TimeSpan.Zero
                };
            });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new() { Title = "Sada API", Version = "v1" });

                // Define the OAuth2.0 scheme that's in use (i.e., Implicit Flow)
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        },
                    Scheme = "oauth2",
                    Name = "Bearer",
                    In = ParameterLocation.Header,
                    },
                    new List<string>()
                    }
                });
            });

        }
    }
}
