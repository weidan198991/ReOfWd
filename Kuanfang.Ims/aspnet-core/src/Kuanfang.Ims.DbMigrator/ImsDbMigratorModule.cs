using Kuanfang.Ims.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Kuanfang.Ims.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ImsEntityFrameworkCoreDbMigrationsModule),
        typeof(ImsApplicationContractsModule)
        )]
    public class ImsDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
