using Volo.Abp.Settings;

namespace RabbitMQ.Source.Settings
{
    public class SourceSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SourceSettings.MySetting1));
        }
    }
}
