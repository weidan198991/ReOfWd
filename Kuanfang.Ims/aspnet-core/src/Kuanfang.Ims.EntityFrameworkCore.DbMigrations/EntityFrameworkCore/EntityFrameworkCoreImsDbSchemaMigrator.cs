using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Kuanfang.Ims.Data;
using Volo.Abp.DependencyInjection;

namespace Kuanfang.Ims.EntityFrameworkCore
{
    public class EntityFrameworkCoreImsDbSchemaMigrator
        : IImsDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreImsDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ImsMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ImsMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}