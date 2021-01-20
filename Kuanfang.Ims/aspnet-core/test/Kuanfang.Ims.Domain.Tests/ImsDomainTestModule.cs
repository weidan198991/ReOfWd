using Kuanfang.Ims.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Kuanfang.Ims
{
    [DependsOn(
        typeof(ImsEntityFrameworkCoreTestModule)
        )]
    public class ImsDomainTestModule : AbpModule
    {

    }
}