using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Kuanfang.Ims.EntityFrameworkCore
{
    [DependsOn(
        typeof(ImsEntityFrameworkCoreModule)
        )]
    public class ImsEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ImsMigrationsDbContext>();
        }
    }
}
