using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Services.Logging.NLogIntegration;
using Castle.Windsor;

namespace Tas.Web.Framework.Installers
{
    public class NLogInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<LoggingFacility>(
                facility => facility
                    .LogUsing<ExtendedNLogFactory>()
                    .WithConfig("NLog.config"));
        }
    }
}