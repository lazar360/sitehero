// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Configuration;
using TestsEntities;

Console.WriteLine("Lancement du test");

ConfigurationBuilder builder = new ConfigurationBuilder();

builder.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json");

var config = builder.Build();

string connectionString = config.GetConnectionString("DefaultContext");

DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();

optionsBuilder.UseSqlServer(connectionString);

using (DefaultContext context = new DefaultContext(optionsBuilder.Options))
{
    var query = from droide in context.Droides
                select droide;

    foreach (var item in query.ToList())
    {
        Console.WriteLine(item.Matricule);
    }
}