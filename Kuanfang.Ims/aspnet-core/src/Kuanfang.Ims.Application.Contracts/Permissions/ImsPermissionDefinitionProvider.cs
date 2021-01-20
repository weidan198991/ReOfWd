using Kuanfang.Ims.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Kuanfang.Ims.Permissions
{
    public class ImsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ImsPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ImsPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ImsResource>(name);
        }
    }
}
