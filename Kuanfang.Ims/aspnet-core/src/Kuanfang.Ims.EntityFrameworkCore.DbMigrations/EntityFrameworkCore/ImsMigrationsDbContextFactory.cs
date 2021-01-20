using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Kuanfang.Ims.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ImsMigrationsDbContextFactory : IDesignTimeDbContextFactory<ImsMigrationsDbContext>
    {
        public ImsMigrationsDbContext CreateDbContext(string[] args)
        {
            ImsEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ImsMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ImsMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Kuanfang.Ims.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
