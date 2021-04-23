namespace ENSEKApi
{
    using ENSEK.Common.Interfaces;
    using ENSEK.Common.Models;
    using ENSEK.Common.Models.Validation;
    using ENSEK.DataAccess;
    using ENSEK.DataAccess.Access;
    using ENSEK.Services;
    using FluentValidation;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.OpenApi.Models;
    using Middlewares;

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

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "Meter Reading API", Version = "v1"});
            });

            var connection = Configuration["ConnectionStrings:SqlServerConnectionString"];

            services.AddDbContext<MeterReadingsDbContext>
                (options => options.UseSqlServer(connection));
            services.AddAutoMapper(typeof(Startup), typeof(MeterReadingsAccess));
            services.AddScoped<IMeterReadingsAccess, MeterReadingsAccess>();
            services.AddScoped<IAccountAccess, AccountAccess>();
            services.AddScoped<IMeterReadingService, MeterReadingService>();
            services.AddSingleton<IValidator<MeterReadingModel>, MeterReadingModelValidator>();
            services.AddSingleton<ICSVService, CsvService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment  env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            // Add middleware for logging unhandled exception. 
            app.UseMiddleware<UnhandledExceptionMiddleware>();

            app.UseHttpsRedirection();
            
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
