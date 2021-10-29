using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Source.Localization;
using Volo.Abp.Application.Services;

namespace RabbitMQ.Destination
{
    /* Inherit your application services from this class.
     */
    public abstract class DestinationAppService : ApplicationService
    {
        protected DestinationAppService()
        {
            LocalizationResource = typeof(SourceResource);
        }
    }
}
