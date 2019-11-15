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

            var viewmodel = new SinanViewModel
            {
                Id = sinan.id,
                usu_codigo = sinan.usu_codigo,
                data_envio = sinan.data_envio,
               
            };            

            return new PdfActionResult("Sinan", viewmodel);
        }        
    }
}