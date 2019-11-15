using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_DadosFinaisViewModel
    {
        public int? violencia_trabalho { get; set; }
        public int? emissao_cat { get; set; }
        public string circunstancia_lesao { get; set; }
        public DateTime? data_encerramento { get; set; }
    }
}
