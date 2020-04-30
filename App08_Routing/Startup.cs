using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace App08_Routing
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
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/hello", async context=> {
                    await context.Response.WriteAsync("Hello World.");
                });

                endpoints.MapGet("/hello/{name:alpha}", async context => {
                    var s = context.Request.RouteValues["name"];
                    await context.Response.WriteAsync($"Hello {s}  How are you ?");
                });

                endpoints.MapGet("/hello/{name:alpha}/{mobile:int}/{address}", async context => {
                    var s = context.Request.RouteValues["name"];
                    var m = context.Request.RouteValues["mobile"];
                    var a = context.Request.RouteValues["address"];
                    await context.Response.WriteAsync($"Hello {s}  How are you ?\nYour Mobile Number is {m}\nYour Address : {a}");
                });

                endpoints.MapControllerRoute(
                      name: "top",
                      pattern: "/{Controller}/{action}/{abc}/{mn}/{dd}");

                endpoints.MapControllerRoute(
                     name: "top1",
                     pattern: "/birthday/{yr:int}/{mn:int}/{dd:int}",
                     defaults: new { Controller = "Data", Action = "Show" });

                endpoints.MapControllerRoute(
                     name: "test1",
                     pattern: "/male/{name:alpha}/{mobile:int}/{address}",
                     defaults : new {Controller="Data", Action="Person" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
