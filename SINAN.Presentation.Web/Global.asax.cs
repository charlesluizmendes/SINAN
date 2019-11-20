using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector;
using SINAN.Application.AutoMapper;
using SINAN.Infrastructure.IoC;

namespace SINAN.Presentation.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        // Log
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            // Código que é executado na inicialização do aplicativo
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // IoC
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(InjetorDependencias.RegisterDependencies()));

            // AutoMapper
            AutoMapperConfig.RegisterMappings();
        }
    }
}
