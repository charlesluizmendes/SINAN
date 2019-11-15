using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRazorToPdf;
using AutoMapper;
using SINAN.Domain.Entities;
using SINAN.Application.Interfaces;
using SINAN.Application.ViewModel;

namespace SINAN.Controllers
{  
    public class RelatoriosController : Controller
    {
        private readonly ISinanAppService _sinanApp;
        private readonly ISinan_DadosDaOcorrenciaAppService _sinanDadosDaOcorrenciaApp;
        private readonly ISinan_DadosDePessoaAtendidaAppService _sinanDadosDePessoaAtendidaApp;
        private readonly ISinan_DadosDoProvavelAutorDaViolenciaAppService _sinanDadosDoProvavelAutorDaViolenciaApp;
        private readonly ISinan_DadosFinaisAppService _sinanDadosFinaisApp;
        private readonly ISinan_DadosGeraisAppService _sinanDadosGeraisApp;
        private readonly ISinan_DadosResidenciaAppService _sinanDadosResidenciaApp;
        private readonly ISinan_EncaminhamentoAppService _sinanEncaminhamentoApp;
        private readonly ISinan_NotificacaoIndividualAppService _sinanNotificacaoIndividualApp;
        private readonly ISinan_NotificadorAppService _sinanNotificadorApp;
        private readonly ISinan_ObservacoesAppService _sinanObservacoesApp;
        private readonly ISinan_ViolenciaAppService _sinanViolenciaApp;
        private readonly ISinan_ViolenciaSexualAppService _sinanViolenciaSexualApp;

        public RelatoriosController(ISinanAppService sinanApp,
                ISinan_DadosDaOcorrenciaAppService sinanDadosDaOcorrenciaApp,
                ISinan_DadosDePessoaAtendidaAppService sinanDadosDePessoaAtendidaApp,
                ISinan_DadosDoProvavelAutorDaViolenciaAppService sinanDadosDoProvavelAutorDaViolenciaApp,
                ISinan_DadosFinaisAppService sinanDadosFinaisApp,
                ISinan_DadosGeraisAppService sinanDadosGeraisApp,
                ISinan_DadosResidenciaAppService sinanDadosResidenciaApp,
                ISinan_EncaminhamentoAppService sinanEncaminhamentoApp,
                ISinan_NotificacaoIndividualAppService sinanNotificacaoIndividualApp,
                ISinan_NotificadorAppService sinanNotificadorApp,
                ISinan_ObservacoesAppService sinanObservacoesApp,
                ISinan_ViolenciaAppService sinanViolenciaApp,
                ISinan_ViolenciaSexualAppService sinanViolenciaSexualApp)
        {
            _sinanApp = sinanApp;
            _sinanDadosDaOcorrenciaApp = sinanDadosDaOcorrenciaApp;
            _sinanDadosDePessoaAtendidaApp = sinanDadosDePessoaAtendidaApp;
            _sinanDadosDoProvavelAutorDaViolenciaApp = sinanDadosDoProvavelAutorDaViolenciaApp;
            _sinanDadosFinaisApp = sinanDadosFinaisApp;
            _sinanDadosGeraisApp = sinanDadosGeraisApp;
            _sinanDadosResidenciaApp = sinanDadosResidenciaApp;
            _sinanEncaminhamentoApp = sinanEncaminhamentoApp;
            _sinanNotificacaoIndividualApp = sinanNotificacaoIndividualApp;
            _sinanNotificadorApp = sinanNotificadorApp;
            _sinanObservacoesApp = sinanObservacoesApp;
            _sinanViolenciaApp = sinanViolenciaApp;
            _sinanViolenciaSexualApp = sinanViolenciaSexualApp;          
        }

        // GET: Relatorios/Sinan
        public PdfActionResult Sinan(int? Id)
        {
            var sinan = _sinanApp.GetById(Id);
            var sinanDadosGerais = _sinanDadosGeraisApp.GetById(Id);
            var sinanNotificacaoIndividual = _sinanNotificacaoIndividualApp.GetById(Id);
            var sinanDadosResidencia = _sinanDadosResidenciaApp.GetById(Id);
            var sinanDadosDePessoaAtendida = _sinanDadosDePessoaAtendidaApp.GetById(Id);
            var sinanDadosDaOcorrencia = _sinanDadosDaOcorrenciaApp.GetById(Id);
            var sinanViolencia = _sinanViolenciaApp.GetById(Id);

            var viewmodel = new SinanViewModel
            {
                Id = sinan.id,
                usu_codigo = sinan.usu_codigo,
                data_envio = sinan.data_envio,
                Sinan_DadosGeraisViewModel = Mapper.Map<Sinan_DadosGerais, Sinan_DadosGeraisViewModel>(sinanDadosGerais),
                Sinan_NotificacaoIndividualViewModel = Mapper.Map<Sinan_NotificacaoIndividual, Sinan_NotificacaoIndividualViewModel>(sinanNotificacaoIndividual),
                Sinan_DadosResidenciaViewModel = Mapper.Map<Sinan_DadosResidencia, Sinan_DadosResidenciaViewModel>(sinanDadosResidencia),
                Sinan_DadosDePessoaAtendidaViewModel = Mapper.Map<Sinan_DadosDePessoaAtendida, Sinan_DadosDePessoaAtendidaViewModel>(sinanDadosDePessoaAtendida),
                Sinan_DadosDaOcorrenciaViewModel = Mapper.Map<Sinan_DadosDaOcorrencia, Sinan_DadosDaOcorrenciaViewModel>(sinanDadosDaOcorrencia),
                Sinan_ViolenciaViewModel = Mapper.Map<Sinan_Violencia, Sinan_ViolenciaViewModel>(sinanViolencia)
            };            

            return new PdfActionResult("Sinan", viewmodel);
        }        
    }
}