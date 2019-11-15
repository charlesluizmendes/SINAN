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
    public class Sinan_DadosDoProvavelAutorDaViolenciaAppService : AppService<Sinan_DadosDoProvavelAutorDaViolencia>, ISinan_DadosDoProvavelAutorDaViolenciaAppService
    {
        private readonly ISinan_DadosDoProvavelAutorDaViolenciaService _sinanDadosDoProvavelAutorDaViolenciaService;

        public Sinan_DadosDoProvavelAutorDaViolenciaAppService(ISinan_DadosDoProvavelAutorDaViolenciaService sinanDadosDoProvavelAutorDaViolenciaService) 
            : base(sinanDadosDoProvavelAutorDaViolenciaService)
        {
            _sinanDadosDoProvavelAutorDaViolenciaService = sinanDadosDoProvavelAutorDaViolenciaService;
        }
    }
}
