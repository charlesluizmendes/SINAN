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
    public class BairroAppService : AppService<Bairro>, IBairroAppService
    {
        private readonly IBairroService _bairroService;

        public BairroAppService(IBairroService bairroService) 
            : base(bairroService)
        {
            _bairroService = bairroService;
        }
    }
}