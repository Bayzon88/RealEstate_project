using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using RealEstate_API.Data;
using VueCliMiddleware;
using Microsoft.AspNetCore.Identity;
using RealEstate_API.Models.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyLesseeDBContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyLesseeDBContext")));

// Adding identity midleware 
builder.Services.AddIdentity<Users, IdentityRole>(options =>
{
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
}).AddEntityFrameworkStores<MyLesseeDBContext>().AddDefaultTokenProviders();
builder.Services.AddScoped<UserManager<Users>>();
builder.Services.AddScoped<SignInManager<Users>>();
builder.Services.AddScoped<JwtValidation>(); //JwtValidation

//*********************** Allow CORS in development environment ***********************
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:8080", "http://localhost:8081")
               .AllowAnyMethod()
         .AllowCredentials()
               .AllowAnyHeader();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors();
    app.UseSwagger();
    app.UseSwaggerUI();

}



app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
