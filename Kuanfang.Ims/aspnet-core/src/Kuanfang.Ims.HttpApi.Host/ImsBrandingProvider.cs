using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Kuanfang.Ims
{
    [Dependency(ReplaceServices = true)]
    public class ImsBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Ims";
    }
}
