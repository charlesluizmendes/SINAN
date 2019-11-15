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
            container.Register<IUnitOfWork, UnitOfWork>();         

            // Service

            container.Register(typeof(IService<>), typeof(Service<>));
            container.Register<IBairroService, BairroService>();
            container.Register<ILogradouroService, LogradouroService>();
            container.Register<IMunicipioService, MunicipioService>();
            container.Register<ISinanService, SinanService>();
            container.Register<ISinan_DadosDaOcorrenciaService, Sinan_DadosDaOcorrenciaService>();
            container.Register<ISinan_DadosDePessoaAtendidaService, Sinan_DadosDePessoaAtendidaService>();
            container.Register<ISinan_DadosDoProvavelAutorDaViolenciaService, Sinan_DadosDoProvavelAutorDaViolenciaService>();
            container.Register<ISinan_DadosFinaisService, Sinan_DadosFinaisService>();
            container.Register<ISinan_DadosGeraisService, Sinan_DadosGeraisService>();
            container.Register<ISinan_DadosResidenciaService, Sinan_DadosResidenciaService>();
            container.Register<ISinan_EncaminhamentoService, Sinan_EncaminhamentoService>();
            container.Register<ISinan_NotificacaoIndividualService, Sinan_NotificacaoIndividualService>();
            container.Register<ISinan_NotificadorService, Sinan_NotificadorService>();
            container.Register<ISinan_ObservacoesService, Sinan_ObservacoesService>();
            container.Register<ISinan_ViolenciaService, Sinan_ViolenciaService>();
            container.Register<ISinan_ViolenciaSexualService, Sinan_ViolenciaSexualService>();
            container.Register<IUsuarioService, UsuarioService>();
            container.Register<IUnidadeService, UnidadeService>();

            // App

            container.Register(typeof(IAppService<>), typeof(AppService<>));            
            container.Register<IBairroAppService, BairroAppService>();
            container.Register<ILogradouroAppService, LogradouroAppService>();
            container.Register<IMunicipioAppService, MunicipioAppService>();
            container.Register<ISinanAppService, SinanAppService>();
            container.Register<ISinan_DadosDaOcorrenciaAppService, Sinan_DadosDaOcorrenciaAppService>();
            container.Register<ISinan_DadosDePessoaAtendidaAppService, Sinan_DadosDePessoaAtendidaAppService>();
            container.Register<ISinan_DadosDoProvavelAutorDaViolenciaAppService, Sinan_DadosDoProvavelAutorDaViolenciaAppService>();
            container.Register<ISinan_DadosFinaisAppService, Sinan_DadosFinaisAppService>();
            container.Register<ISinan_DadosGeraisAppService, Sinan_DadosGeraisAppService>();
            container.Register<ISinan_DadosResidenciaAppService, Sinan_DadosResidenciaAppService>();
            container.Register<ISinan_EncaminhamentoAppService, Sinan_EncaminhamentoAppService>();
            container.Register<ISinan_NotificacaoIndividualAppService, Sinan_NotificacaoIndividualAppService>();
            container.Register<ISinan_NotificadorAppService, Sinan_NotificadorAppService>();
            container.Register<ISinan_ObservacoesAppService, Sinan_ObservacoesAppService>();
            container.Register<ISinan_ViolenciaAppService, Sinan_ViolenciaAppService>();
            container.Register<ISinan_ViolenciaSexualAppService, Sinan_ViolenciaSexualAppService>();
            container.Register<IUsuarioAppService, UsuarioAppService>();
            container.Register<IUnidadeAppService, UnidadeAppService>();           

            return container;
        }
    }
}
