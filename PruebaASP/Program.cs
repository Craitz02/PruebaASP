using Microsoft.EntityFrameworkCore;
using PruebaASP.Controllers;
using PruebaASP.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BdempresaContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConecction")
    ));


builder.Services.AddScoped<ProductoController>();
builder.Services.AddScoped<CategoriaController>();

builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
