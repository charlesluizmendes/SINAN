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
using SINAN.Application.Interfaces;
using SINAN.Application.ViewModel;
using SINAN.Infrastructure.CrossCutting.Helpers;

namespace SINAN.Controllers
{
    [Authorize]
    public class SinanController : Controller
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
        private readonly IBairroAppService _bairroApp;
        private readonly ILogradouroAppService _logradouroApp;
        private readonly IMunicipioAppService _municipioApp;
        private readonly IUnidadeAppService _unidadeApp;

        public SinanController(ISinanAppService sinanApp,
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
            ISinan_ViolenciaSexualAppService sinanViolenciaSexualApp,
            IBairroAppService bairroApp,
            ILogradouroAppService logradouroApp,
            IMunicipioAppService municipioApp,
            IUnidadeAppService unidadeApp)
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
            DateTime? searchDataEnvio,
            int? page)
        {
            var obj = (from sinan in _sinanApp.Get()
                       join sinanNoticacaoIndividual in _sinanNotificacaoIndividualApp.Get() on sinan.id equals sinanNoticacaoIndividual.id
                       join sinanDadosGerais in _sinanDadosGeraisApp.Get() on sinan.id equals sinanDadosGerais.id
                       join sinanViolencia in _sinanViolenciaApp.Get() on sinan.id equals sinanViolencia.id
                       select new
                       {
                           searchNome,
                           searchDataNascimento,
                           searchCartaoSUS,
                           searchMotivoOcorrencia,
                           searchDataOcorrencia,
                           searchDataEnvio,
                           sinanNoticacaoIndividual.id,
                           sinanNoticacaoIndividual.nome_paciente,
                           sinanNoticacaoIndividual.data_nascimento,
                           sinanNoticacaoIndividual.num_cartaosus,
                           sinanViolencia.motivo_ocorrencia,
                           sinanDadosGerais.data_violencia,
                           sinan.data_envio
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

            if (searchDataEnvio != null)
            {
                obj = obj.Where(a => a.data_envio != null && a.data_envio.Equals(searchDataEnvio))
                    .ToList();
            }

            var viewmodel = Mapper.Map<List<ListarViewModel>>(obj);

            int paginaTamanho = 10;
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

                _sinanApp.Insert(sinan);
                _sinanApp.Commit();

                var sinanDadosGerais = Mapper.Map<Sinan_DadosGeraisViewModel, Sinan_DadosGerais>(viewmodel.Sinan_DadosGeraisViewModel);
                sinanDadosGerais.id = sinan.id;

                _sinanDadosGeraisApp.Insert(sinanDadosGerais);
                _sinanDadosGeraisApp.Commit();

                var sinanNotificacaoIndividual = Mapper.Map<Sinan_NotificacaoIndividualViewModel, Sinan_NotificacaoIndividual>(viewmodel.Sinan_NotificacaoIndividualViewModel);
                sinanNotificacaoIndividual.id = sinan.id;

                _sinanNotificacaoIndividualApp.Insert(sinanNotificacaoIndividual);
                _sinanNotificacaoIndividualApp.Commit();

                var sinanDadosResidencia = Mapper.Map<Sinan_DadosResidenciaViewModel, Sinan_DadosResidencia>(viewmodel.Sinan_DadosResidenciaViewModel);
                sinanDadosResidencia.id = sinan.id;

                _sinanDadosResidenciaApp.Insert(sinanDadosResidencia);
                _sinanDadosResidenciaApp.Commit();

                var sinanDadosDePessoaAtendida = Mapper.Map<Sinan_DadosDePessoaAtendidaViewModel, Sinan_DadosDePessoaAtendida>(viewmodel.Sinan_DadosDePessoaAtendidaViewModel);
                sinanDadosDePessoaAtendida.id = sinan.id;

                _sinanDadosDePessoaAtendidaApp.Insert(sinanDadosDePessoaAtendida);
                _sinanDadosDePessoaAtendidaApp.Commit();

                var sinanDadosDaOcorrencia = Mapper.Map<Sinan_DadosDaOcorrenciaViewModel, Sinan_DadosDaOcorrencia>(viewmodel.Sinan_DadosDaOcorrenciaViewModel);
                sinanDadosDaOcorrencia.id = sinan.id;

                _sinanDadosDaOcorrenciaApp.Insert(sinanDadosDaOcorrencia);
                _sinanDadosDaOcorrenciaApp.Commit();

                var sinanViolencia = Mapper.Map<Sinan_ViolenciaViewModel, Sinan_Violencia>(viewmodel.Sinan_ViolenciaViewModel);
                sinanViolencia.id = sinan.id;

                _sinanViolenciaApp.Insert(sinanViolencia);
                _sinanViolenciaApp.Commit();

                var sinanViolenciaSexual = Mapper.Map<Sinan_ViolenciaSexualViewModel, Sinan_ViolenciaSexual>(viewmodel.Sinan_ViolenciaSexualViewModel);
                sinanViolenciaSexual.id = sinan.id;

                _sinanViolenciaSexualApp.Insert(sinanViolenciaSexual);
                _sinanViolenciaSexualApp.Commit();

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
            var sinan = _sinanApp.GetById(Id);
            var sinanDadosGerais = _sinanDadosGeraisApp.GetById(Id);
            var sinanNotificacaoIndividual = _sinanNotificacaoIndividualApp.GetById(Id);
            var sinanDadosResidencia = _sinanDadosResidenciaApp.GetById(Id);
            var sinanDadosDePessoaAtendida = _sinanDadosDePessoaAtendidaApp.GetById(Id);
            var sinanDadosDaOcorrencia = _sinanDadosDaOcorrenciaApp.GetById(Id);
            var sinanViolencia = _sinanViolenciaApp.GetById(Id);
            var sinanViolenciaSexual = _sinanViolenciaSexualApp.GetById(Id);

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
                Sinan_ViolenciaSexualViewModel = Mapper.Map<Sinan_ViolenciaSexual, Sinan_ViolenciaSexualViewModel>(sinanViolenciaSexual)
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

                _sinanApp.Update(sinan);
                _sinanApp.Commit();

                var sinanDadosGerais = Mapper.Map<Sinan_DadosGeraisViewModel, Sinan_DadosGerais>(viewmodel.Sinan_DadosGeraisViewModel);
                sinanDadosGerais.id = sinan.id;

                _sinanDadosGeraisApp.Update(sinanDadosGerais);
                _sinanDadosGeraisApp.Commit();

                var sinanNotificacaoIndividual = Mapper.Map<Sinan_NotificacaoIndividualViewModel, Sinan_NotificacaoIndividual>(viewmodel.Sinan_NotificacaoIndividualViewModel);
                sinanNotificacaoIndividual.id = sinan.id;

                _sinanNotificacaoIndividualApp.Update(sinanNotificacaoIndividual);
                _sinanNotificacaoIndividualApp.Commit();

                var sinanDadosResidencia = Mapper.Map<Sinan_DadosResidenciaViewModel, Sinan_DadosResidencia>(viewmodel.Sinan_DadosResidenciaViewModel);
                sinanDadosResidencia.id = sinan.id;

                _sinanDadosResidenciaApp.Update(sinanDadosResidencia);
                _sinanDadosResidenciaApp.Commit();

                var sinanDadosDePessoaAtendida = Mapper.Map<Sinan_DadosDePessoaAtendidaViewModel, Sinan_DadosDePessoaAtendida>(viewmodel.Sinan_DadosDePessoaAtendidaViewModel);
                sinanDadosDePessoaAtendida.id = sinan.id;

                _sinanDadosDePessoaAtendidaApp.Update(sinanDadosDePessoaAtendida);
                _sinanDadosDePessoaAtendidaApp.Commit();

                var sinanDadosDaOcorrencia = Mapper.Map<Sinan_DadosDaOcorrenciaViewModel, Sinan_DadosDaOcorrencia>(viewmodel.Sinan_DadosDaOcorrenciaViewModel);
                sinanDadosDaOcorrencia.id = sinan.id;

                _sinanDadosDaOcorrenciaApp.Update(sinanDadosDaOcorrencia);
                _sinanDadosDaOcorrenciaApp.Commit();

                var sinanViolencia = Mapper.Map<Sinan_ViolenciaViewModel, Sinan_Violencia>(viewmodel.Sinan_ViolenciaViewModel);
                sinanViolencia.id = sinan.id;

                _sinanViolenciaApp.Update(sinanViolencia);
                _sinanViolenciaApp.Commit();

                var sinanViolenciaSexual = Mapper.Map<Sinan_ViolenciaSexualViewModel, Sinan_ViolenciaSexual>(viewmodel.Sinan_ViolenciaSexualViewModel);
                sinanViolenciaSexual.id = sinan.id;

                _sinanViolenciaSexualApp.Update(sinanViolenciaSexual);
                _sinanViolenciaSexualApp.Commit();

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
