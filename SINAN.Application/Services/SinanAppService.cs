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
    public class SinanAppService : AppService<Sinan>, ISinanAppService
    {
        private readonly ISinanService _sinanService;

        public SinanAppService(ISinanService sinanService) 
            : base(sinanService)
        {
            _sinanService = sinanService;
        }
    }
}