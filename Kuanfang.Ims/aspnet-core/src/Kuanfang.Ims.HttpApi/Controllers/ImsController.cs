using Kuanfang.Ims.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kuanfang.Ims.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ImsController : AbpController
    {
        protected ImsController()
        {
            LocalizationResource = typeof(ImsResource);
        }
    }
}