using RabbitMQ.Source.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RabbitMQ.Source.Permissions
{
    public class SourcePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SourcePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(SourcePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SourceResource>(name);
        }
    }
}
