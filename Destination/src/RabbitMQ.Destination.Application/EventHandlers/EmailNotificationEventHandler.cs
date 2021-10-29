using RabbitMQ.Source.NotificationEventData;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace RabbitMQ.Destination.EventHandlers
{
    public class EmailNotificationEventHandler : IDistributedEventHandler<EmailNotificationEventData>, ITransientDependency
    {
        public EmailNotificationEventHandler()
        {

        }

        public Task HandleEventAsync(EmailNotificationEventData eventData)
        {
            return Task.FromResult(eventData.NotificationId);
        }
    }
}
