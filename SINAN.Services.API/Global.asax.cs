using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Integration.Web.Mvc;
using SINAN.Application.AutoMapper;
using SINAN.Infrastructure.IoC;

namespace SINAN.Services.API
{
    public class Global : HttpApplication
    {
        // Log
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        void Application_Start(object sender, EventArgs e)
        {
            // Código que é executado na inicialização do aplicativo
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // IoC
            var container = InjetorDependencias.RegisterDependencies();
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            DependencyResolver.SetResolver(
               new SimpleInjectorDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            // AutoMapper
            AutoMapperConfig.RegisterMappings();
        }
    }
}