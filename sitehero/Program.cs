using sitehero.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sitehero.Core.Data.DataLayer;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultContext");

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<ParagrapheDataLayer, ParagrapheDataLayer>();

builder.Services.AddDbContext<DefaultContext>(options =>
    options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

builder.Services.AddSession(options => {
    options.Cookie.Name = ".sitehero.session";
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});

var app = builder.Build();


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

app.UseSession();

app.MapControllerRoute(
    name: "aventure-creation",
    pattern: "demarrer-une-nouvelle-aventure",
    defaults: new { controller = "Aventure", action = "Create" });

app.MapControllerRoute(
    name: "aventure-edition",
    pattern: "continuer-une-aventure/{id}",
    defaults: new { controller = "Aventure", action = "Edit" },
    constraints: new { id = @"\d+" });

app.MapControllerRoute(
    name: "mesaventures",
    pattern: "mes-aventures",
    defaults: new { controller = "Aventure", action = "Index" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

