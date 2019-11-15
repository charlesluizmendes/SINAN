using System;
using System.Collections.Generic;
using SimpleInjector;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Interfaces;
using SINAN.Application.Services;
using SINAN.Domain.Entities;
using SINAN.Domain.Interfaces.Repository;
using SINAN.Domain.Interfaces.Services;
using SINAN.Domain.Services;
using SINAN.Infrastructure.Data.Repository;

namespace SINAN.Infrastructure.IoC
{
    public static class InjetorDependencias
    {
        public static Container RegisterDependencies()
        {
            var container = new Container();

            // Repository

            container.Register(typeof(IRepository<>), typeof(Repository<>));
            container.Register<IBairroRepository, BairroRepository>();
            container.Register<ILogradouroRepository, LogradouroRepository>();
            container.Register<IMunicipioRepository, MunicipioRepository>();
            container.Register<IUnidadeRepository, UnidadeRepository>();
            container.Register<IUsuarioRepository, UsuarioRepository>();

            // Unit of Work

            container.Register<IUnitOfWork, UnitOfWork>();

            // Service

            container.Register(typeof(IService<>), typeof(Service<>));
            container.Register<IBairroService, BairroService>();
            container.Register<ILogradouroService, LogradouroService>();
            container.Register<IMunicipioService, MunicipioService>();            
            container.Register<IUsuarioService, UsuarioService>();
            container.Register<IUnidadeService, UnidadeService>();

            // App

            container.Register(typeof(IAppService<>), typeof(AppService<>));            
            container.Register<IBairroAppService, BairroAppService>();
            container.Register<ILogradouroAppService, LogradouroAppService>();
            container.Register<IMunicipioAppService, MunicipioAppService>();            
            container.Register<IUsuarioAppService, UsuarioAppService>();
            container.Register<IUnidadeAppService, UnidadeAppService>();         

            return container;
        }
    }
}
