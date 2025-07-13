using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace WebApiHandson
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Swagger Demo",
                    Version = "v1",
                    Description = "TBD",
                    Contact = new OpenApiContact { Name = "John Doe", Email = "john@xyzmail.com", Url = new System.Uri("https://www.example.com") },
                    License = new OpenApiLicense { Name = "License Terms", Url = new System.Uri("https://www.example.com") }
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Demo"); });
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}