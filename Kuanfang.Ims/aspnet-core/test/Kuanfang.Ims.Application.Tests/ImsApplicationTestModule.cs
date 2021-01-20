using Volo.Abp.Modularity;

namespace Kuanfang.Ims
{
    [DependsOn(
        typeof(ImsApplicationModule),
        typeof(ImsDomainTestModule)
        )]
    public class ImsApplicationTestModule : AbpModule
    {

    }
}