using System.Threading.Tasks;

namespace RabbitMQ.Source.Data
{
    public interface ISourceDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
