using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using tutorial_mvc_net.Data;
using tutorial_mvc_net.Models;
using tutorial_mvc_net.Models.SeedData;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<tutorial_mvc_netContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("tutorial_mvc_netContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services); // aca trae todos los objetos inicializados en este archivo
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();