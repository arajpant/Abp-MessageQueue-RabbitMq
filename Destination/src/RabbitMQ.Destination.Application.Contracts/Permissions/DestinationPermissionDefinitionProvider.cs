using RabbitMQ.Source.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RabbitMQ.Destination.Permissions
{
    public class DestinationPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DestinationPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(DestinationPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SourceResource>(name);
        }
    }
}
