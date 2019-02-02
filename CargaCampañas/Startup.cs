using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargaCampañas.Models;
using CargaCampañas.Models.CMP_GESTION;
using CargaCampañas.Models.Motor_SAS_V2;
using CargaCampañas.Models.Origen;
using CargaCampañas.Models.SASBD_NEW_2;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace CargaCampañas
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var connectionString = Configuration.GetConnectionString("SQLServerPORTD05_CMP_GESTION");
            services.AddDbContext<CMP_GESTIONContext>(
                options => options.UseSqlServer(connectionString)
                );
            var connectionString2 = Configuration.GetConnectionString("SQLServerV1");
            services.AddDbContext<SAS_CampaignContext>(
                options => options.UseSqlServer(connectionString2)
                );
            var connectionString3 = Configuration.GetConnectionString("SQLServerPORTD05_Motor_SAS_V2");
            services.AddDbContext<MOTOR_SAS_V2Context>(
                options => options.UseSqlServer(connectionString3)
                );
            var connectionString4 = Configuration.GetConnectionString("SQLServerPORTD05_SASBD_NEW_2");
            services.AddDbContext<SASBD_NEW_2Context>(
                options => options.UseSqlServer(connectionString4)
                );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
