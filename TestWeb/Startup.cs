using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using WEB.Application;
using WEB.Domain.Interface;
using WEB.Domain.Service;

namespace TestWeb
{
    public class Startup
    {
        public readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHealthChecks();
            services.AddSwaggerGen(c=> {
                c.SwaggerDoc("v1",new Microsoft.OpenApi.Models.OpenApiInfo { Title="Backend Api",Version="V1"});
            });
            services.AddControllers();
            // 向容器注册服务：第一个参数为类型，第二个参数为实例
            services.AddTransient<IStudentApplication, StudentApplication>();
            services.AddTransient<IStudentDomainService, StudentDomainService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("George API V1");
                });
                endpoints.MapHealthChecks("/health");
                endpoints.MapControllers();
            });
        }
    }
}
