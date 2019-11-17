using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using PagedList.Mvc;
using AutoMapper;
using PagedList;
using SINAN.Domain.Entities;
using SINAN.Domain.Interfaces.Repository;
using SINAN.Application.Interfaces;
using SINAN.Application.ViewModel;
using SINAN.Infrastructure.CrossCutting.Helpers;

namespace SINAN.Controllers
{
    [Authorize]
    public class SinanController : Controller
    {
        private readonly IUnitOfWork _uow;        
        private readonly IBairroAppService _bairroApp;
        private readonly ILogradouroAppService _logradouroApp;
        private readonly IMunicipioAppService _municipioApp;
        private readonly IUnidadeAppService _unidadeApp;

        public SinanController(IUnitOfWork uow,            
            IBairroAppService bairroApp,
            ILogradouroAppService logradouroApp,
            IMunicipioAppService municipioApp,
            IUnidadeAppService unidadeApp)
        {
            _uow = uow;            
            _bairroApp = bairroApp;
            _logradouroApp = logradouroApp;
            _municipioApp = municipioApp;
            _unidadeApp = unidadeApp;
        }
        
        // GET: Sinan/Listar
        public ActionResult Listar(string searchNome,
            DateTime? searchDataNascimento,
            string searchCartaoSUS,
            int? searchMotivoOcorrencia,
            DateTime? searchDataOcorrencia,
            int? page)
        {
            var obj = (from sinan in _uow.sinan.Get()
                       join sinanNoticacaoIndividual in _uow.sinanNotificacaoIndividual.Get() on sinan.id equals sinanNoticacaoIndividual.id
                       join sinanDadosGerais in _uow.sinanDadosGerais.Get() on sinan.id equals sinanDadosGerais.id
                       join sinanViolencia in _uow.sinanViolencia.Get() on sinan.id equals sinanViolencia.id
                       select new
                       {
                           searchNome,
                           searchDataNascimento,
                           searchCartaoSUS,
                           searchMotivoOcorrencia,
                           searchDataOcorrencia,
                           sinanNoticacaoIndividual.id,
                           sinanNoticacaoIndividual.nome_paciente,
                           sinanNoticacaoIndividual.data_nascimento,
                           sinanNoticacaoIndividual.num_cartaosus,
                           sinanViolencia.motivo_ocorrencia,
                           sinanDadosGerais.data_violencia,
                       })
                      .ToList();

            if (!String.IsNullOrEmpty(searchNome))
            {
                obj = obj.Where(a => a.nome_paciente != null && a.nome_paciente.ToUpper().Contains(searchNome.ToUpper()))
                    .ToList();
            }

            if (searchDataNascimento != null)
            {
                obj = obj.Where(a => a.data_nascimento != null && a.data_nascimento.Equals(searchDataNascimento))
                    .ToList();
            }

            if (!String.IsNullOrEmpty(searchCartaoSUS))
            {
                obj = obj.Where(a => a.num_cartaosus != null && a.num_cartaosus.Contains(searchCartaoSUS))
                    .ToList();
            }

            if (searchMotivoOcorrencia > 0)
            {
                obj = obj.Where(a => a.motivo_ocorrencia != null && a.motivo_ocorrencia.Equals(searchMotivoOcorrencia))
                    .ToList();
            }

            if (searchDataOcorrencia != null)
            {
                obj = obj.Where(a => a.data_violencia != null && a.data_violencia.Equals(searchDataOcorrencia))
                    .ToList();
            }            

            var viewmodel = Mapper.Map<List<ListarViewModel>>(obj);

            int paginaTamanho = 5;
            int paginaNumero = (page ?? 1);

            return View(viewmodel.ToPagedList(paginaNumero, paginaTamanho));
        }

        // GET: Sinan/Criar
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Sinan/Criar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(string submitButton, SinanViewModel viewmodel)
        {
            if (ModelState.IsValid)
            {
                var sinan = new Sinan
                {
                    usu_codigo = Convert.ToInt32(Session["usu_codigo"]),
                    data_envio = DateTime.Now
                };

                _uow.sinan.Insert(sinan);
                _uow.sinan.Commit();

                var sinanDadosGerais = Mapper.Map<Sinan_DadosGeraisViewModel, Sinan_DadosGerais>(viewmodel.Sinan_DadosGeraisViewModel);
                sinanDadosGerais.id = sinan.id;
                _uow.sinanDadosGerais.Insert(sinanDadosGerais);

                var sinanNotificacaoIndividual = Mapper.Map<Sinan_NotificacaoIndividualViewModel, Sinan_NotificacaoIndividual>(viewmodel.Sinan_NotificacaoIndividualViewModel);
                sinanNotificacaoIndividual.id = sinan.id;
                _uow.sinanNotificacaoIndividual.Insert(sinanNotificacaoIndividual);

                var sinanDadosResidencia = Mapper.Map<Sinan_DadosResidenciaViewModel, Sinan_DadosResidencia>(viewmodel.Sinan_DadosResidenciaViewModel);
                sinanDadosResidencia.id = sinan.id;
                _uow.sinanDadosResidencia.Insert(sinanDadosResidencia);

                var sinanDadosDePessoaAtendida = Mapper.Map<Sinan_DadosDePessoaAtendidaViewModel, Sinan_DadosDePessoaAtendida>(viewmodel.Sinan_DadosDePessoaAtendidaViewModel);
                sinanDadosDePessoaAtendida.id = sinan.id;
                _uow.sinanDadosDePessoaAtendida.Insert(sinanDadosDePessoaAtendida);

                var sinanDadosDaOcorrencia = Mapper.Map<Sinan_DadosDaOcorrenciaViewModel, Sinan_DadosDaOcorrencia>(viewmodel.Sinan_DadosDaOcorrenciaViewModel);
                sinanDadosDaOcorrencia.id = sinan.id;
                _uow.sinanDadosDaOcorrencia.Insert(sinanDadosDaOcorrencia);

                var sinanViolencia = Mapper.Map<Sinan_ViolenciaViewModel, Sinan_Violencia>(viewmodel.Sinan_ViolenciaViewModel);
                sinanViolencia.id = sinan.id;
                _uow.sinanViolencia.Insert(sinanViolencia);

                var sinanViolenciaSexual = Mapper.Map<Sinan_ViolenciaSexualViewModel, Sinan_ViolenciaSexual>(viewmodel.Sinan_ViolenciaSexualViewModel);
                sinanViolenciaSexual.id = sinan.id;
                _uow.sinanViolenciaSexual.Insert(sinanViolenciaSexual);

                var sinanDadosDoProvavelAutorDaViolencia = Mapper.Map<Sinan_DadosDoProvavelAutorViolenciaViewModel, Sinan_DadosDoProvavelAutorDaViolencia>(viewmodel.Sinan_DadosDoProvavelAutorViolenciaViewModel);
                sinanDadosDoProvavelAutorDaViolencia.id = sinan.id;
                _uow.sinanDadosDoProvavelAutorDaViolencia.Insert(sinanDadosDoProvavelAutorDaViolencia);

                var sinanEncaminhamento = Mapper.Map<Sinan_EncaminhamentoViewModel, Sinan_Encaminhamento>(viewmodel.Sinan_EncaminhamentoViewModel);
                sinanEncaminhamento.id = sinan.id;
                _uow.sinanEncaminhamento.Insert(sinanEncaminhamento);

                var sinanDadosFinais = Mapper.Map<Sinan_DadosFinaisViewModel, Sinan_DadosFinais>(viewmodel.Sinan_DadosFinaisViewModel);
                sinanDadosFinais.id = sinan.id;
                _uow.sinanDadosFinais.Insert(sinanDadosFinais);

                var sinanObservacoes = Mapper.Map<Sinan_ObservacoesViewModel, Sinan_Observacoes>(viewmodel.Sinan_ObservacoesViewModel);
                sinanObservacoes.id = sinan.id;
                _uow.sinanObservacoes.Insert(sinanObservacoes);

                var sinanNotificador = Mapper.Map<Sinan_NotificadorViewModel, Sinan_Notificador>(viewmodel.Sinan_NotificadorViewModel);
                sinanNotificador.id = sinan.id;
                _uow.sinanNotificador.Insert(sinanNotificador);

                _uow.Commit();

                TempData["Success"] = "SINAN Cadastrado";

                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                return View(viewmodel);
            }
        }

        // GET: Sinan/Editar      
        public ActionResult Editar(int Id)
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

            return View(viewmodel);
        }

        // POST: Sinan/Criar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int? Id, SinanViewModel viewmodel)
        {
            if (ModelState.IsValid)
            {              
                var sinan = new Sinan
                {
                    id = Convert.ToInt32(Id),
                    usu_codigo = Convert.ToInt32(Session["usu_codigo"]),
                    data_envio = DateTime.Now
                };
                _uow.sinan.Update(sinan);

                var sinanDadosGerais = Mapper.Map<Sinan_DadosGeraisViewModel, Sinan_DadosGerais>(viewmodel.Sinan_DadosGeraisViewModel);
                sinanDadosGerais.id = sinan.id;
                _uow.sinanDadosGerais.Update(sinanDadosGerais);

                var sinanNotificacaoIndividual = Mapper.Map<Sinan_NotificacaoIndividualViewModel, Sinan_NotificacaoIndividual>(viewmodel.Sinan_NotificacaoIndividualViewModel);
                sinanNotificacaoIndividual.id = sinan.id;
                _uow.sinanNotificacaoIndividual.Update(sinanNotificacaoIndividual);

                var sinanDadosResidencia = Mapper.Map<Sinan_DadosResidenciaViewModel, Sinan_DadosResidencia>(viewmodel.Sinan_DadosResidenciaViewModel);
                sinanDadosResidencia.id = sinan.id;
                _uow.sinanDadosResidencia.Update(sinanDadosResidencia);

                var sinanDadosDePessoaAtendida = Mapper.Map<Sinan_DadosDePessoaAtendidaViewModel, Sinan_DadosDePessoaAtendida>(viewmodel.Sinan_DadosDePessoaAtendidaViewModel);
                sinanDadosDePessoaAtendida.id = sinan.id;
                _uow.sinanDadosDePessoaAtendida.Update(sinanDadosDePessoaAtendida);

                var sinanDadosDaOcorrencia = Mapper.Map<Sinan_DadosDaOcorrenciaViewModel, Sinan_DadosDaOcorrencia>(viewmodel.Sinan_DadosDaOcorrenciaViewModel);
                sinanDadosDaOcorrencia.id = sinan.id;
                _uow.sinanDadosDaOcorrencia.Update(sinanDadosDaOcorrencia);

                var sinanViolencia = Mapper.Map<Sinan_ViolenciaViewModel, Sinan_Violencia>(viewmodel.Sinan_ViolenciaViewModel);
                sinanViolencia.id = sinan.id;
                _uow.sinanViolencia.Update(sinanViolencia);

                var sinanViolenciaSexual = Mapper.Map<Sinan_ViolenciaSexualViewModel, Sinan_ViolenciaSexual>(viewmodel.Sinan_ViolenciaSexualViewModel);
                sinanViolenciaSexual.id = sinan.id;
                _uow.sinanViolenciaSexual.Update(sinanViolenciaSexual);

                var sinanDadosDoProvavelAutorDaViolencia = Mapper.Map<Sinan_DadosDoProvavelAutorViolenciaViewModel, Sinan_DadosDoProvavelAutorDaViolencia>(viewmodel.Sinan_DadosDoProvavelAutorViolenciaViewModel);
                sinanDadosDoProvavelAutorDaViolencia.id = sinan.id;
                _uow.sinanDadosDoProvavelAutorDaViolencia.Update(sinanDadosDoProvavelAutorDaViolencia);

                var sinanEncaminhamento = Mapper.Map<Sinan_EncaminhamentoViewModel, Sinan_Encaminhamento>(viewmodel.Sinan_EncaminhamentoViewModel);
                sinanEncaminhamento.id = sinan.id;
                _uow.sinanEncaminhamento.Update(sinanEncaminhamento);

                var sinanDadosFinais = Mapper.Map<Sinan_DadosFinaisViewModel, Sinan_DadosFinais>(viewmodel.Sinan_DadosFinaisViewModel);
                sinanDadosFinais.id = sinan.id;
                _uow.sinanDadosFinais.Update(sinanDadosFinais);

                var sinanObservacoes = Mapper.Map<Sinan_ObservacoesViewModel, Sinan_Observacoes>(viewmodel.Sinan_ObservacoesViewModel);
                sinanObservacoes.id = sinan.id;
                _uow.sinanObservacoes.Update(sinanObservacoes);

                var sinanNotificador = Mapper.Map<Sinan_NotificadorViewModel, Sinan_Notificador>(viewmodel.Sinan_NotificadorViewModel);
                sinanNotificador.id = sinan.id;
                _uow.sinanNotificador.Update(sinanNotificador);

                _uow.Commit();

                TempData["Success"] = "SINAN Alterado";

                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                return View(viewmodel);
            }
        }

        #region "Eventos das DropDownList's Dinâmicas"

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetMunicipio(string ufe_sg)
        {
            var obj = _municipioApp.Get()
                .Where(a => a.ufe_sg.Equals(ufe_sg))
                .OrderBy(a => a.loc_no)
                .Select(a => new
                {
                    value = a.loc_un,
                    text = a.loc_no
                })
                .ToList();

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetBairro(double loc_nu)
        {
            var obj = _bairroApp.Get()
                 .Where(a => a.loc_nu.Equals(loc_nu))
                 .OrderBy(a => a.bai_no)
                 .Select(a => new
                 {
                     value = a.bai_nu,
                     text = a.bai_no
                 })
                 .ToList();

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetUnidade(string codufmun)
        {
            var obj = _unidadeApp.Get()
                 .Where(a => a.codufmun.Equals(codufmun))
                 .OrderBy(a => a.fantasia)
                 .Select(a => new
                 {
                     value = a.id,
                     text = a.fantasia
                 })
                 .ToList();

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetCodigoIBGE(double loc_un)
        {
            var obj = _municipioApp.Get()
                 .Where(a => a.loc_un.Equals(loc_un))
                 .Select(a => new
                 {
                     text = a.mun_nu
                 })
                 .FirstOrDefault();

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetCodigoCNES(int id)
        {
            var obj = _unidadeApp.Get()
                 .Where(a => a.id.Equals(id))
                 .Select(a => new
                 {
                     text = a.cnes
                 })
                 .FirstOrDefault();

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetEndereco(string cep)
        {
            var obj = (from mun in _municipioApp.Get()
                       join bai in _bairroApp.Get() on mun.loc_un equals bai.loc_nu
                       join log in _logradouroApp.Get() on bai.bai_nu equals log.bai_nu_ini
                       where (log.cep.Equals(cep))
                       select new
                       {
                           mun.ufe_sg,
                           mun.loc_un,
                           mun.loc_no,
                           mun.mun_nu,
                           bai.bai_nu,
                           bai.bai_no,
                           log.tlo_tx,
                           log.log_no
                       })
                      .FirstOrDefault();

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}
