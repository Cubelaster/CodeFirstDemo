using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DatabasesEntities.Context
{
    public class SysKitContextFactory : IDesignTimeDbContextFactory<SysKitContext>
    {
        public SysKitContext CreateDbContext(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("Hosting:Environment");
            var baseDirectory = Directory.GetCurrentDirectory();
            return CreateDbContext(environmentName, baseDirectory);
        }

        public SysKitContext CreateDbContext(string environmentName, string baseDirectory)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(baseDirectory)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", true)
                .AddEnvironmentVariables()
                .Build();

            var connectionString = configuration.GetConnectionString("SysKitConnection");
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "Could not find a connection string named '(DefaultConnection)'.");
            }
            return CreateDbContext(connectionString);
        }

        public SysKitContext CreateDbContext(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException($"{nameof(connectionString)} is null or empty.", nameof(connectionString));
            }

            var optionsBuilder = new DbContextOptionsBuilder<SysKitContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new SysKitContext(optionsBuilder.Options);
        }
    }
}
