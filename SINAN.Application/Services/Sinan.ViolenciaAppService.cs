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
    public class Sinan_ViolenciaAppService : AppService<Sinan_Violencia>, ISinan_ViolenciaAppService
    {
        private readonly ISinan_ViolenciaService _usuarioViolenciaService;

        public Sinan_ViolenciaAppService(ISinan_ViolenciaService usuarioViolenciaService) 
            : base(usuarioViolenciaService)
        {
            _usuarioViolenciaService = usuarioViolenciaService;
        }
    }
}
