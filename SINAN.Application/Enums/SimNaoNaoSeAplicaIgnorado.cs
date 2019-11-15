using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum  SimNaoNaoSeAplicaIgnorado
    {
        [Display(Name = "Sim")]
        Sim = 1,

        [Display(Name = "Não")]
        Nao = 2,

        [Display(Name = "Não se Aplica")]
        NaoSeAplica = 8,

        [Display(Name = "Ignorado")]
        Ignorado = 9,
    }
}
