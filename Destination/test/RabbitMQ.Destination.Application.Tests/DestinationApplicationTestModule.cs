using Volo.Abp.Modularity;

namespace RabbitMQ.Destination
{
    [DependsOn(
        typeof(DestinationApplicationModule),
        typeof(DestinationDomainTestModule)
        )]
    public class DestinationApplicationTestModule : AbpModule
    {

    }
}