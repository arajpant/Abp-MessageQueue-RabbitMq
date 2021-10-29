using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace RabbitMQ.Destination
{
    [Dependency(ReplaceServices = true)]
    public class DestinationBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Destination";
    }
}
