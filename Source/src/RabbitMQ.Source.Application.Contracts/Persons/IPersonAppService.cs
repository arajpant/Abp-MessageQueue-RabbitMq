using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace RabbitMQ.Source.Persons
{
    public interface IPersonAppService : IApplicationService
    {
        Task<bool> WishBirthdayAsync();
    }
}
