using Volo.Abp.Modularity;

namespace RabbitMQ.Source
{
    [DependsOn(
        typeof(SourceApplicationModule),
        typeof(SourceDomainTestModule)
        )]
    public class SourceApplicationTestModule : AbpModule
    {

    }
}