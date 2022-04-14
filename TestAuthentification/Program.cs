using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TestAuthentification.Areas.Identity.Data;
using TestAuthentification.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("TestAuthentificationContextConnection");

builder.Services.AddDbContext<TestAuthentificationContext>(options =>
    options.UseSqlServer(connectionString));builder.Services.AddDefaultIdentity<TestAuthentificationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<TestAuthentificationContext>();
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.MapRazorPages();

app.Run();
