using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AutoMapper;
using SINAN.Domain.Entities;
using SINAN.Application.Interfaces;
using SINAN.Application.ViewModel;
using SINAN.Infrastructure.CrossCutting.Helpers;
using Microsoft.IdentityModel.Tokens;

namespace SINAN.Services.API.Controllers
{
    public class TokenController : ApiController
    {
        private readonly IUsuarioAppService _usuarioApp;

        public TokenController(IUsuarioAppService usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        [HttpPost]
        public HttpResponseMessage Post(LoginViewModel viewmodel)
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
                        var claims = new[]
                        {
                             new Claim(ClaimTypes.Name, usuario.usu_email.ToString())
                        };

                        var key = new SymmetricSecurityKey(
                            System.Text.Encoding.Default.GetBytes("qwertyqwertyqwertyqwerty")
                            );

                        var creds = new SigningCredentials(
                            key, SecurityAlgorithms.HmacSha256Signature
                            );

                        var token = new JwtSecurityToken(
                            issuer: "eco.sistemas",
                            audience: "eco.sistemas",
                            expires: DateTime.UtcNow.AddMinutes(30),
                            claims: claims,
                            signingCredentials: creds
                            );

                        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                        return Request.CreateResponse(HttpStatusCode.OK, new {
                            token = tokenString,
                            expiration = token.ValidTo
                        });
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.Unauthorized,
                            "Usuario bloqueado");
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.Unauthorized,
                        "Usuario e/ou Senha incorreto(s)");
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }        
    }
}
