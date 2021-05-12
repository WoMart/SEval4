using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SEval4.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4
{
    public class Startup
    {
        #region DataDirectory placeholder string

        private static readonly string _dataDirectory = 
            Path.Combine(Directory.GetCurrentDirectory(), "Data");

        #endregion

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            #region Database

            // Define database context
            services.AddDbContext<SEvalDBContext>(
                context => context.UseSqlServer(
                    Configuration.GetConnectionString("SevalDev")
                    .Replace("%DataDirectory%", _dataDirectory)
                    ));

            // Define Service to utilise the database
            services.AddScoped<SurveyService>();

            #endregion

            #region Client-side storage

            // Enables Cloudcrate's Local- and SessionStorage
            services.AddStorage();

            // Add a custom service to operate on SessionStorage
            services.AddTransient(
                sp => new CustomStorage(
                    sp.GetService<Microsoft.JSInterop.IJSRuntime>()));

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
