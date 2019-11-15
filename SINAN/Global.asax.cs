using System;
using System.Collections.Generic;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SINAN.Application.AutoMapper;
using SINAN.Infrastructure.IoC;

namespace SINAN
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(InjetorDependencias.RegisterDependencies()));
            AutoMapperConfig.RegisterMappings();           
        }
    }
}
