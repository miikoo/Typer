using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Text;
using Typer.Application.Commands.Gameweeks.CreateGameweek;
using Typer.Application.Commands.Seasons.CreateSeason;
using Typer.Application.Services.JwtGenerator;
using Typer.Application.Services.PasswordHasher;
using Typer.Domain.Interfaces.Repositories;
using Typer.Infrastructure;
using Typer.Infrastructure.QueryHandlers.Seasons;
using Typer.Infrastructure.Repositories;
using RestEase;
using Typer.Application.Client.PLClient;
using Typer.Domain.Interfaces.Services;
using Typer.Infrastructure.PLClientSevice;

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
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateGameweekCommandValidator>());
            services.AddMediatR(typeof(GetSeasonsQueryHandler), typeof(CreateSeasonCommandHandler));
            services.AddScoped<IMediator, Mediator>();
            services.AddTransient<IPLClientService, PLClientService>();
            services.AddTransient<IJwtGenerator, JwtGenerator>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ISeasonRepository, SeasonRepository>();
            services.AddTransient<IGameweekRepository, GameweekRepository>();
            services.AddTransient<IMatchRepository, MatchRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<IMatchPredictionRepository, MatchPredictionRepository>();
            services.AddTransient<IPasswordHasher, PasswordHasher>();
            services.AddTransient(x => RestClient.For<IPLClient>
            ("https://heisenbug-premier-league-live-scores-v1.p.rapidapi.com/api/premierleague/"));
            services.ConfigureSwaggerGen(options => { options.CustomSchemaIds(x => x.FullName); });
            services.AddSwaggerGen(c => 
            { 
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Typer API", Version = "v1" });

                c.AddSecurityDefinition("oauth2", new ApiKeyScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
                    In = "header",
                    Name = "Authorization",
                    Type = "apiKey"
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();
            });


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
                .AllowAnyHeader()
                .AllowAnyOrigin());
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Typer API V1"); });
            app.UseMiddleware(typeof(ErrorHandlingMiddleware));
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
