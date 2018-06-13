using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BL.DtoToViewModelMappings;
using BL.Services.ConcreteImplementations;
using BL.Services.Contracts;
using DAL.DatabaseToDtoMappings;
using DAL.Repository;
using DAL.Repository.Contracts;
using DatabasesEntities.Context;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using FromDatabase.Models;

namespace CodeFirstDemo
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
            services.AddDbContext<SysKitContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("SysKitConnection"), 
                opts => opts.MigrationsAssembly("DatabasesEntities")));

            services.AddDbContext<SysKitCodeFirstDemoContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("SysKitConnection"), 
            opts => opts.MigrationsAssembly("FromDatabase")));


            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddAutoMapper(typeof(DtoMappingsProfile), typeof(ViewModelMappings));

            // TODO
            services.AddMvc().AddFluentValidation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true,
                    ReactHotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
