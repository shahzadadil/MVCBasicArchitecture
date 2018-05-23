using Castle.Core.Logging;
using Castle.Windsor;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Tas.Framework;

namespace Tas.Web.Framework
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        private static WindsorContainer _DependencyContainer;
        public ILogger Logger { get; set; }

        public CustomControllerFactory()
        {
            _DependencyContainer = DependencyContainer.Instance;
        }

        protected override IController GetControllerInstance(
            RequestContext requestContext, 
            Type controllerType)
        {
            if (controllerType == null)
            {
                var errorMessage = $"The controller for path {requestContext.HttpContext.Request.Path} could not be found.";
                Logger.Error(errorMessage);
                throw new HttpException(404, errorMessage);
            }

            return (IController)_DependencyContainer.Resolve(controllerType);            
        }

        public override void ReleaseController(IController controller)
        {
            _DependencyContainer.Release(controller);
        }
    }
}