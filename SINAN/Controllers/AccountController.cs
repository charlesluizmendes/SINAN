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
    public class AccountController : Controller
    {
        private readonly IUsuarioAppService _usuarioApp;

        public AccountController(IUsuarioAppService usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        // GET: Account/Login
        public ActionResult Login()
        {
            var viewmodel = new LoginViewModel();

            return View(viewmodel);
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel viewmodel)
        {
            if (ModelState.IsValid)
            {
                var usuario = Mapper.Map<LoginViewModel, Usuario>(viewmodel);

                usuario.usu_senha = MD5Hash.GetMd5Hash(usuario.usu_senha);

                var obj = _usuarioApp.Get()
                    .Where(a => a.usu_email.Equals(usuario.usu_email))
                    .Where(b => b.usu_senha.Equals(usuario.usu_senha))
                    .FirstOrDefault();               

                if (obj != null)
                {
                    if (Equals(obj.usu_ativo, true))
                    {
                        FormsAuthentication.SetAuthCookie(obj.usu_email, false);

                        Session["usu_codigo"] = obj.usu_codigo;
                        Session["usu_nome"] = obj.usu_nome;
                        Session["usu_email"] = obj.usu_email;

                        return RedirectToAction("Dashboard", "Home");
                    }
                    else
                    {
                        TempData["Error"] = "Usuario bloqueado";

                        return View(viewmodel);
                    }
                }
                else
                {
                    TempData["Error"] = "Usuario e/ou Senha incorreto(s)";

                    return View(viewmodel);
                }
            }
            else
            {
                return View(viewmodel);
            }
        }

        // GET: Account/RecuperarSenha
        public ActionResult RecuperarSenha()
        {
            var viewmodel = new RecuperarSenhaViewModel();

            return View(viewmodel);
        }

        // POST: Account/RecuperarSenha
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RecuperarSenha(RecuperarSenhaViewModel viewmodel)
        {
            if (ModelState.IsValid)
            {
                var usuario = Mapper.Map<RecuperarSenhaViewModel, Usuario>(viewmodel);

                if (ValidarCPF.ValidateCPF(usuario.usu_cpf))
                {
                    var obj = _usuarioApp.Get()
                        .Where(a => a.usu_cpf.Equals(usuario.usu_cpf))
                        .Where(b => b.usu_email.Equals(usuario.usu_email))
                        .FirstOrDefault();

                    if (obj != null)
                    {
                        if (Equals(obj.usu_ativo, true))
                        {
                            usuario.usu_senha = GerarSenha.GetGeneratePassword();
                            obj.usu_senha = MD5Hash.GetMd5Hash(usuario.usu_senha);

                            _usuarioApp.Update(obj);
                            _usuarioApp.Commit();                           

                            EnviarEmail.SendEmail(
                                "no-reply@ecosistemas.com.br", 
                                "no-reply",
                                usuario.usu_email, 
                                usuario.usu_nome,
                                "SINAN - Nova senha de acesso",
                                "Prezado(a),\nSua nova senha de acesso é: " + usuario.usu_senha + "\n\nAtenciosamente SINAN."                               
                                );

                            TempData["Success"] = "Senha Enviada";

                            return RedirectToAction("Login", "Account");
                        }
                        else
                        {
                            TempData["Error"] = "Usuario bloqueado";

                            return View(viewmodel);
                        }
                    }
                    else
                    {
                        TempData["Error"] = "Usuario nao encontrado";

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
    }
}