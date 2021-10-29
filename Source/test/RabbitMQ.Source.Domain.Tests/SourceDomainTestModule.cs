using RabbitMQ.Source.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RabbitMQ.Source
{
    [DependsOn(
        typeof(SourceEntityFrameworkCoreTestModule)
        )]
    public class SourceDomainTestModule : AbpModule
    {

    }
}