using Volo.Abp.Settings;

namespace Kuanfang.Ims.Settings
{
    public class ImsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ImsSettings.MySetting1));
        }
    }
}
