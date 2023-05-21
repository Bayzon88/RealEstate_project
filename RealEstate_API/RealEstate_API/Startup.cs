using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RealEstate_API.Data;
using RealEstate_API.Models;

namespace RealEstate_API
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

           
        }
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddMemoryCache();
            services.AddSession();
         

            //Database Context to create Database in SQL server
            services.AddDbContext<MyLesseeDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MyLesseeDBContext")));

            //Identity Framework config
            services.AddIdentity<Account, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<MyLesseeDBContext>()
              .AddDefaultTokenProviders();
            services.AddScoped<UserManager<Account>>();
        }

    }
}
