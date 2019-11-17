using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum OuIdade
    {
        [Display(Name = "Hora")]
        Hora = 1,

        [Display(Name = "Dia")]
        Dia = 2,

        [Display(Name = "Mês")]
        Mes = 3,

        [Display(Name = "Ano")]
        Ano = 4        
    }
}
