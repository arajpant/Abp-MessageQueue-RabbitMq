using RabbitMQ.Source.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace RabbitMQ.Source.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SourceEntityFrameworkCoreModule),
        typeof(SourceApplicationContractsModule)
        )]
    public class SourceDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
