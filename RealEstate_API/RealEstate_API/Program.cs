using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using RealEstate_API.Data;
using VueCliMiddleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyLesseeDBContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyLesseeDBContext")));

//*********************** Single page application configuration for Vue.js ***********************
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "client"; //Use static files from client(vuejs project)
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

//Single page application configuration for Vue.js
app.UseSpaStaticFiles();
app.UseSpa(spa =>
{
    if (app.Environment.IsDevelopment())
    {
        spa.Options.SourcePath = "client/"; //Development folder
    }
    else
    {
        spa.Options.SourcePath = "dis"; //Production folder
    }

    if (app.Environment.IsDevelopment()) spa.UseVueCli(npmScript: "serve");//Vue.js script of package.json
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
