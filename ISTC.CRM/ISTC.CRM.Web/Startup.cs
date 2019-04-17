using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISTC.CRM.DAL;
using ISTC.CRM.DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.Extensions.DependencyInjection;


namespace ISTC.CRM.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        private List<ConnectionTable> list = new List<ConnectionTable>();
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                //User user = new User()
                //{
                //    Email = "edvin1984edvin@gmail.com",
                //    Name = "Edvin",
                //    Surname = "Hakobyan",
                //    ConnectionTable = list
                //};

                //DB_Operations.Create(user);
                await context.Response.WriteAsync(DB_Operations.Read(1).Name + " " + DB_Operations.Read(1).Surname +
                                                  " " + DB_Operations.Read(1).Email);
            });
        }
    }
}
