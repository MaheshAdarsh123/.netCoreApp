using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //To add use MVC architecture, below code is added
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async(context , next) =>
            //{
            //    await context.Response.WriteAsync("Hello from 1st MiddleWare");
            //    await next();
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from 2nd MiddleWare");
            //});

            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        if (env.IsDevelopment())
            //        {
            //            await context.Response.WriteAsync("Env is dev");
            //        }
            //        else if(env.IsProduction())
            //        {
            //            await context.Response.WriteAsync("Env is prod");
            //        }
            //        else if (env.IsStaging())
            //        {
            //            await context.Response.WriteAsync("Env is stag");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync(env.EnvironmentName);
            //        }
            //    });
            //});

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/mahesh", async context =>
                //{
                //    await context.Response.WriteAsync("Hello mahesh!");
                //});
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
