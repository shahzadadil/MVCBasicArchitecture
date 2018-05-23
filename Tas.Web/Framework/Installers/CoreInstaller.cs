using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Tas.Core.Requests;
using Tas.Core.Repositories;

namespace Tas.Web.Framework.Installers
{
    public class CoreInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes
                    .FromAssemblyContaining<ProductRepository>()
                    .InSameNamespaceAs<ProductRepository>()
                    .WithServiceAllInterfaces()
                    .LifestyleTransient());

            container.Register(
                Classes
                    .FromAssemblyContaining<IRequest>()
                    .InSameNamespaceAs<IRequest>()
                    .WithServiceAllInterfaces()
                    .LifestyleTransient());
        }
    }
}