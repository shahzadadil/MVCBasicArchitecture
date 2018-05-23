using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Tas.Framework;
using Tas.Web.Framework;

namespace Tas.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            SetupIoc();
        }

        private void SetupIoc()
        {
            var dependencyContainer = DependencyContainer.Instance;
            dependencyContainer.Install(FromAssembly.This());

            var customControllerFactory = new CustomControllerFactory();
            ControllerBuilder.Current.SetControllerFactory(customControllerFactory);
        }
    }
}
