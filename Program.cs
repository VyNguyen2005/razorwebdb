using System.Configuration;
using Microsoft.EntityFrameworkCore;
using razorweb;
using razorweb.models;

/* var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MyBlogContext>(options => {
    string connStr = builder.Configuration.GetConnectionString("MyBlogContext");
    options.UseSqlServer(connStr);
});
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run(); */

var builder = Host.CreateDefaultBuilder(args);
builder.ConfigureWebHostDefaults((IWebHostBuilder webBuilder) => {
    webBuilder.UseStartup<Startup>();
});

var app = builder.Build();

app.Run();
/*
    dotnet tool install --global dotnet-ef
    dotnet tool install --global dotnet-aspnet-codegenerator
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
*/
