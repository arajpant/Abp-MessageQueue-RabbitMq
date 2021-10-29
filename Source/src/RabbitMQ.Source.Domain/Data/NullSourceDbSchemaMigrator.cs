using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RabbitMQ.Source.Data
{
    /* This is used if database provider does't define
     * ISourceDbSchemaMigrator implementation.
     */
    public class NullSourceDbSchemaMigrator : ISourceDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}