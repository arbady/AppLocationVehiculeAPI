using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ModelClient.Data;
using ModelClient.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API
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

            services.AddControllers();

            services.AddScoped<IRepoAgency<AgencyClient>, AgencyClientService>();
            services.AddScoped<IRepoBill<BillClient>, BillClientService>();
            services.AddScoped<IRepoCategory<CategoryClient>, CategoryClientService>();
            services.AddScoped<IRepoContract<ContractClient>, ContractClientService>();
            services.AddScoped<IRepoDisponibilities<DisponibilitiesClient>, DisponibilitiesClientService>();
            services.AddScoped<IRepoLicence<LicenceClient>, LicenceClientService>();
            services.AddScoped<IRepoMark<MarkClient>, MarkClientService>();
            services.AddScoped<IRepoModel<ModeleClient>, ModelClientService>();
            services.AddScoped<IRepoPaymentMethod<PaymentMethodClient>, PaymentMethodClientService>();
            services.AddScoped<IRepoPenalization<PenalizationClient>, PenalizationClientService>();
            services.AddScoped<IRepoReservation<ReservationClient>, ReservationClientService>();
            services.AddScoped<IRepoState<StateClient>, StateClientService>();
            services.AddScoped<IRepoUser<UserClient>, UserClientService>();
            services.AddScoped<IRepoVehicle<VehicleClient>, VehicleClientService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LocationVehicule.API", Version = "v1" });
            });

            IConfigurationSection jwtSection = Configuration.GetSection("JWTSettings");
            services.Configure<JWTSettings>(jwtSection);

            var appSettings = jwtSection.Get<JWTSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);

            services.AddAuthentication(
                a =>
                {
                    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(b => {
                    b.RequireHttpsMetadata = true;
                    b.SaveToken = true;
                    b.TokenValidationParameters = new TokenValidationParameters
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
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LocationVehicule.API v1"));
            }

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
