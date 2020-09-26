using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using Typer.Infrastructure;
using MediatR;
using Typer.Infrastructure.Repositories;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Typer.Domain.Interfaces;

namespace Typer.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x => x.EnableEndpointRouting = false);
            services.AddDbContext<TyperContext>(options =>
            options.UseMySQL(Configuration.GetConnectionString("TyperConnectionString")));

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<IMediator, Mediator>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ISeasonRepository, SeasonRepository>();
            services.AddTransient<IGameweekRepository, GameweekRepository>();
            services.AddTransient<IMatchRepository, MatchRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<IMatchPredictionRepository, MatchPredictionRepository>();
            services.AddControllers();

            var key = Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings").GetSection("Secret").Value);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            app.UseRouting();

            app.UseAuthorization();
            app.UseMvc();
        }
    }
}
