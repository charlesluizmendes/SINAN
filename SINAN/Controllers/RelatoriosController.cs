using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRazorToPdf;
using AutoMapper;
using SINAN.Domain.Entities;
using SINAN.Domain.Interfaces.Repository;
using SINAN.Application.Interfaces;
using SINAN.Application.ViewModel;
using SINAN.Infrastructure.CrossCutting.Helpers;

namespace SINAN.Controllers
{  
    public class RelatoriosController : Controller
    {
        private readonly IUnitOfWork _uow;

        public RelatoriosController(IUnitOfWork uow)               
        {
            _uow = uow;
        }

        // GET: Relatorios/Sinan
        public PdfActionResult Sinan(int? Id)
        {
            var sinan = _uow.sinan.GetById(Id);
            var sinanDadosGerais = _uow.sinanDadosGerais.GetById(Id);
            var sinanNotificacaoIndividual = _uow.sinanNotificacaoIndividual.GetById(Id);
            var sinanDadosResidencia = _uow.sinanDadosResidencia.GetById(Id);
            var sinanDadosDePessoaAtendida = _uow.sinanDadosDePessoaAtendida.GetById(Id);
            var sinanDadosDaOcorrencia = _uow.sinanDadosDaOcorrencia.GetById(Id);
            var sinanViolencia = _uow.sinanViolencia.GetById(Id);
            var sinanViolenciaSexual = _uow.sinanViolenciaSexual.GetById(Id);
            var sinanDadosDoProvavelAutorDaViolencia = _uow.sinanDadosDoProvavelAutorDaViolencia.GetById(Id);
            var sinanEncaminhamento = _uow.sinanEncaminhamento.GetById(Id);
            var sinanDadosFinais = _uow.sinanDadosFinais.GetById(Id);
            var sinanObservacoes = _uow.sinanObservacoes.GetById(Id);
            var sinanNotificador = _uow.sinanNotificador.GetById(Id);

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
                Sinan_ViolenciaViewModel = Mapper.Map<Sinan_Violencia, Sinan_ViolenciaViewModel>(sinanViolencia),
                Sinan_ViolenciaSexualViewModel = Mapper.Map<Sinan_ViolenciaSexual, Sinan_ViolenciaSexualViewModel>(sinanViolenciaSexual),
                Sinan_DadosDoProvavelAutorViolenciaViewModel = Mapper.Map<Sinan_DadosDoProvavelAutorDaViolencia, Sinan_DadosDoProvavelAutorViolenciaViewModel>(sinanDadosDoProvavelAutorDaViolencia),
                Sinan_EncaminhamentoViewModel = Mapper.Map<Sinan_Encaminhamento, Sinan_EncaminhamentoViewModel>(sinanEncaminhamento),
                Sinan_DadosFinaisViewModel = Mapper.Map<Sinan_DadosFinais, Sinan_DadosFinaisViewModel>(sinanDadosFinais),
                Sinan_ObservacoesViewModel = Mapper.Map<Sinan_Observacoes, Sinan_ObservacoesViewModel>(sinanObservacoes),
                Sinan_NotificadorViewModel = Mapper.Map<Sinan_Notificador, Sinan_NotificadorViewModel>(sinanNotificador)
            };            

            return new PdfActionResult("Sinan", viewmodel);
        }        
    }
}