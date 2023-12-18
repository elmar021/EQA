using EQA.Business.Services.Implementations;
using EQA.Business.Services.Interfaces;
using EQA.Core.Models;
using EQA.Core.Repositories.Interfaces;
using EQA.Data.DataAccessLayer;
using EQA.Data.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPortfolioRepository, PortfolioRepository>();
builder.Services.AddScoped<IPortfolioService, PortfolioService>();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-LUGHNBO;Database=EQAContext;Trusted_Connection=True");
});
var app = builder.Build();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();
app.UseSession();
app.UseAuthorization();
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute
    (
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapControllerRoute
    (
        name:"default",
        pattern:"{controller=EQA}/{action=Index}"
    );
app.Run();
