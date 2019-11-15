using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Domain.Interfaces.Repository;
using SINAN.Domain.Interfaces.Services;
using SINAN.Domain.Entities;

namespace SINAN.Domain.Services
{
    public class Sinan_DadosResidenciaService : Service<Sinan_DadosResidencia>, ISinan_DadosResidenciaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public Sinan_DadosResidenciaService(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
