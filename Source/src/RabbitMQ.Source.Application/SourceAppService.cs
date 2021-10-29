using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Source.Localization;
using Volo.Abp.Application.Services;

namespace RabbitMQ.Source
{
    /* Inherit your application services from this class.
     */
    public abstract class SourceAppService : ApplicationService
    {
        protected SourceAppService()
        {
            LocalizationResource = typeof(SourceResource);
        }
    }
}
