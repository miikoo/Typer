using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql;
using Typer.Infrastructure;
using MediatR;
using Typer.Infrastructure.Repositories;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Typer.Domain.Interfaces;
using Microsoft.OpenApi.Models;
using Typer.Infrastructure.QueryHandlers.Seasons;
using Typer.Application.Commands.Season.CreateSeason;

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
            services.AddCors();
            services.AddDbContext<TyperContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("TyperConnectionString")));
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
            services.AddMvc(x => x.EnableEndpointRouting = false)
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
            services.AddMediatR(typeof(GetSeasonsQueryHandler), typeof(CreateSeasonCommandHandler));
            services.AddScoped<IMediator, Mediator>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ISeasonRepository, SeasonRepository>();
            services.AddTransient<IGameweekRepository, GameweekRepository>();
            services.AddTransient<IMatchRepository, MatchRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<IMatchPredictionRepository, MatchPredictionRepository>();
            services.ConfigureSwaggerGen(options => { options.CustomSchemaIds(x => x.FullName); });
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "Typer API", Version = "v1" }); });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          //  if (env.IsDevelopment())
               // app.UseHsts();

            //app.UseHttpsRedirection();
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Typer API V1"); });

            app.UseAuthorization();
            app.UseMvc();
        }
    }
}
