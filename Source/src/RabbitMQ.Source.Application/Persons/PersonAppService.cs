using RabbitMQ.Source.LocalEventData;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.EventBus.Local;

namespace RabbitMQ.Source.Persons
{
    public class PersonAppService : ApplicationService, IPersonAppService
    {
        private readonly ILocalEventBus _localEventBus;

        public PersonAppService(
            ILocalEventBus localEventBus
            )
        {
            _localEventBus = localEventBus;
        }

        public async Task<bool> WishBirthdayAsync()
        {
            await _localEventBus.PublishAsync(
                new BirthdayWishEventData
                {
                    PersonId = Guid.NewGuid()
                });

            return true;
        }
    }
}
