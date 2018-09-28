using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SemesterManagement.Configurations;
using SemesterManagement.Models;

namespace SemesterManagement
{
    public class Startup
    {
        readonly IConfiguration configuration;

        public Startup(IHostingEnvironment env)
        {
            configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddJsonFile(env.ContentRootPath + "/config.json")
                .AddJsonFile(env.ContentRootPath + "/config.development.json", true)
                .Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<DevelopmentSettings>(de => new DevelopmentSettings
            {
                EnableDeveloperException = configuration.GetValue<bool>("DevelopmentSettings:EnableDeveloperException")
            });

            services.AddDbContext<SMDBContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                options.UseMySql(connectionString);
            });
            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, DevelopmentSettings devSettings)
        {
            app.UseStatusCodePagesWithReExecute("/Error/{0}");

            if (devSettings.EnableDeveloperException)
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) => {

                await next.Invoke();
            });

            app.UseMvc(routes => {
               
                routes.MapRoute(
                   name: "Default",
                   template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}