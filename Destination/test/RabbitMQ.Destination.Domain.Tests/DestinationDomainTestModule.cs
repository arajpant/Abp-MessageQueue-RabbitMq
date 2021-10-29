using RabbitMQ.Destination.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RabbitMQ.Destination
{
    [DependsOn(
        typeof(DestinationEntityFrameworkCoreTestModule)
        )]
    public class DestinationDomainTestModule : AbpModule
    {

    }
}