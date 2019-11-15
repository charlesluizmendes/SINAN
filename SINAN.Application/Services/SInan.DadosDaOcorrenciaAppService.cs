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
    public class Sinan_DadosDaOcorrenciaAppService : AppService<Sinan_DadosDaOcorrencia>, ISinan_DadosDaOcorrenciaAppService
    {
        private readonly ISinan_DadosDaOcorrenciaService _sinan_DadosDaOcorrenciaService;

        public Sinan_DadosDaOcorrenciaAppService(ISinan_DadosDaOcorrenciaService sinan_DadosDaOcorrenciaService) 
            : base(sinan_DadosDaOcorrenciaService)
        {
            _sinan_DadosDaOcorrenciaService = sinan_DadosDaOcorrenciaService;
        }
    }
}
