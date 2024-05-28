
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApiAuth.data;

namespace WebApiAuth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Step 1: Configure EF DbContext
            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("constr")));

            //Step 2: Configure API Endpoints for Identity
            builder.Services.AddIdentityApiEndpoints<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            //Step 3: Add Authorization middleware into pipeline
            builder.Services.AddAuthorization();

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


            app.MapControllers();

            app.Run();
        }
    }
}
