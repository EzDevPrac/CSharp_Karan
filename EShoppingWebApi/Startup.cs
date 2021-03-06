using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using EShoppingWebApi.Service.EmployeeService;
using EShoppingWebApi.Service.CustomerServices;
using EShoppingWebApi.Service.ProductHandler;
using EShoppingWebApi.Validation.CustomerDataValidation;
using EShoppingWebApi.Validation.ProductValidation;
using EShoppingWebApi.Service.CartHandler;
//using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
namespace EShoppingWebApi
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
             services.AddScoped<ICustomerService, CustomerService>();
             services.AddScoped<ICustomerInformationValidation, CustomerInformationValidation>();
             services.AddScoped<IProductHandler,ProductHandler>();
             services.AddScoped<IProductValidation,ProductValidation>();
             services.AddScoped<IEmployeeService,EmployeeService>();
             services.AddScoped<ICartHandler,CartHandler>();
             services.AddMvc();
             services.AddSwaggerGen(c =>
            {
             c.SwaggerDoc("v1", new OpenApiInfo { Title = "EShopping.com", Version = "v1" });
            });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
            app.UseSwagger();


         // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.

            app.UseSwaggerUI(c =>
            {
              c.SwaggerEndpoint("/swagger/v1/swagger.json", "EShopping.com V1");
            });
        }
    }
}
