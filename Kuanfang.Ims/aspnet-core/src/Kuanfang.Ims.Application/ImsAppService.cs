using System;
using System.Collections.Generic;
using System.Text;
using Kuanfang.Ims.Localization;
using Volo.Abp.Application.Services;

namespace Kuanfang.Ims
{
    /* Inherit your application services from this class.
     */
    public abstract class ImsAppService : ApplicationService
    {
        protected ImsAppService()
        {
            LocalizationResource = typeof(ImsResource);
        }
    }
}
