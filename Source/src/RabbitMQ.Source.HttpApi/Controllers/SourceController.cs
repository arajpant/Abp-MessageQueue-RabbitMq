using RabbitMQ.Source.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RabbitMQ.Source.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SourceController : AbpController
    {
        protected SourceController()
        {
            LocalizationResource = typeof(SourceResource);
        }
    }
}