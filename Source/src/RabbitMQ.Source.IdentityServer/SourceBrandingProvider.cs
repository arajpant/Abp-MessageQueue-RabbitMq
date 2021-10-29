using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace RabbitMQ.Source
{
    [Dependency(ReplaceServices = true)]
    public class SourceBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Source";
    }
}
