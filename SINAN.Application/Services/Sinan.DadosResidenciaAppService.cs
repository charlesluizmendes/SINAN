using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Interfaces;
using SINAN.Domain.Interfaces.Services;
using SINAN.Domain.Entities;

namespace SINAN.Application.Services
{
    public class Sinan_DadosResidenciaAppService : AppService<Sinan_DadosResidencia>, ISinan_DadosResidenciaAppService
    {
        private readonly ISinan_DadosResidenciaService _usuarioDadosResidenciaService;

        public Sinan_DadosResidenciaAppService(ISinan_DadosResidenciaService usuarioDadosResidenciaService) 
            : base(usuarioDadosResidenciaService)
        {
            _usuarioDadosResidenciaService = usuarioDadosResidenciaService;
        }
    }
}
