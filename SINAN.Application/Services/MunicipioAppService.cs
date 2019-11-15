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
    public class MunicipioAppService : AppService<Municipio>, IMunicipioAppService
    {
        private readonly IMunicipioService _municipioService;

        public MunicipioAppService(IMunicipioService municipioService) 
            : base(municipioService)
        {
            _municipioService = municipioService;
        }
    }
}