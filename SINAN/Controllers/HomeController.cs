using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using SINAN.Domain.Entities;
using SINAN.Application.Interfaces;
using SINAN.Application.ViewModel;
using SINAN.Infrastructure.CrossCutting.Helpers;

namespace SINAN.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUsuarioAppService _usuarioApp;

        public HomeController(IUsuarioAppService usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        // GET: Home/Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }

        [Authorize(Roles = "Administrador")]
        public ActionResult CriarConta()
        {
            var viewmodel = new CriarContaViewModel();

            return View(viewmodel);
        }

        // POST: Home/CriarConta
        [Authorize(Roles = "Administrador")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarConta(CriarContaViewModel viewmodel)
        {
            if (ModelState.IsValid)
            {
                var usuario = Mapper.Map<CriarContaViewModel, Usuario>(viewmodel);

                usuario.usu_senha = MD5Hash.GetMd5Hash(usuario.usu_senha);
                usuario.usu_datacadastro = DateTime.Now;

                if (ValidarCPF.ValidateCPF(usuario.usu_cpf))
                {
                    var obj = _usuarioApp.Get()
                        .Where(a => a.usu_cpf.Equals(usuario.usu_cpf))
                        .FirstOrDefault();

                    if (obj == null)
                    {
                        var obj_ = _usuarioApp.Get()
                            .Where(a => a.usu_email.Equals(usuario.usu_email))
                            .FirstOrDefault();

                        if (obj_ == null)
                        {
                            _usuarioApp.Insert(usuario);
                            _usuarioApp.Commit();                          

                            TempData["Success"] = "Conta Cadastrada";

                            return RedirectToAction("Dashboard", "Home");
                        }
                        else
                        {
                            TempData["Error"] = "E-mail ja cadastrado";

                            return View(viewmodel);
                        }
                    }
                    else
                    {
                        TempData["Error"] = "CPF ja cadastrado";

                        return View(viewmodel);
                    }
                }
                else
                {
                    TempData["Error"] = "CPF invalido";

                    return View(viewmodel);
                }
            }
            else
            {
                return View(viewmodel);
            }
        }

        // GET: Home/AlteraSenha
        public ActionResult AlterarSenha()
        {
            var viewmodel = new AlterarSenhaViewModel();

            return View(viewmodel);
        }

        // POST: Home/AlteraSenha
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarSenha(AlterarSenhaViewModel viewmodel)
        {
            if (ModelState.IsValid)
            {
                var usuario = Mapper.Map<AlterarSenhaViewModel, Usuario>(viewmodel);

                usuario.usu_codigo = Convert.ToInt32(Session["usu_codigo"]);
                usuario.usu_senha = MD5Hash.GetMd5Hash(viewmodel.usu_senha_anterior);

                var obj = _usuarioApp.Get()
                    .Where(a => a.usu_codigo.Equals(usuario.usu_codigo))
                    .Where(a => a.usu_senha.Equals(usuario.usu_senha))
                    .FirstOrDefault();

                if (obj != null)
                {
                    obj.usu_senha = MD5Hash.GetMd5Hash(viewmodel.usu_senha);

                    _usuarioApp.Update(obj);
                    _usuarioApp.Commit();                    

                    FormsAuthentication.SignOut();
                    Session.Clear();

                    TempData["Success"] = "Senha Alterada";

                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    TempData["Error"] = "A Senha atual esta incorreta";

                    return View(viewmodel);
                }
            }
            else
            {
                return View(viewmodel);
            }
        }

        // GET: Home/Logout
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            return RedirectToAction("Login", "Account");
        }
    }
}