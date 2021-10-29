using RabbitMQ.Source.LocalEventData;
using RabbitMQ.Source.NotificationEventData;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;
using Volo.Abp.EventBus.Distributed;

namespace RabbitMQ.Source.LocalEventHandlers
{
    public class BirthdayWishEventHandler : ILocalEventHandler<BirthdayWishEventData>,
          ITransientDependency
    {
        private readonly IDistributedEventBus _distributedEventBus;

        public BirthdayWishEventHandler(
            IDistributedEventBus distributedEventBus
            )
        {
            _distributedEventBus = distributedEventBus;
        }

        public async Task HandleEventAsync(BirthdayWishEventData eventData)
        {
            var emailNotification = new EmailNotificationEventData
            {
                NotificationId = Guid.NewGuid()
            };

            await _distributedEventBus.PublishAsync(emailNotification);
        }
    }
}
