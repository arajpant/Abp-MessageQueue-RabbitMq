using RabbitMQ.Source.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RabbitMQ.Destination.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DestinationController : AbpController
    {
        protected DestinationController()
        {
            LocalizationResource = typeof(SourceResource);
        }
    }
}