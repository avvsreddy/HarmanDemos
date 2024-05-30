
using CoolProductsCatalogService.Model.Data;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsCatalogService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // inject dbcontext using built in IoC
            string conStr = builder.Configuration.GetConnectionString("constr");
            builder.Services.AddDbContext<ProductsDbContext>(options =>
            {

                options.UseSqlServer(conStr);

            });


            // Step 1: Inject IdentityDbContext
            builder.Services.AddDbContext<AppIdentityDbContext>(options =>
            {
                options.UseSqlServer(conStr);
            });

            //Step 2: Configure API Endpoints for Identity
            builder.Services.AddIdentityApiEndpoints<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>();

            //Step 3: Add Authorization middleware into pipeline
            builder.Services.AddAuthorization();

            builder.Services.AddControllers().AddXmlSerializerFormatters();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Step 1:  Odata support
            builder.Services.AddOData();
            var app = builder.Build();

            //Step 4: Map Identity API
            app.MapIdentityApi<IdentityUser>();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }




            app.UseHttpsRedirection();

            app.UseAuthorization();

            // Step 2 for ODATA
            //app.MapControllers();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.EnableDependencyInjection();
                endpoints.Select().OrderBy().Filter().MaxTop(10).Count().SkipToken();
                endpoints.MapControllers();

            });
            app.Run();
        }
    }
}
