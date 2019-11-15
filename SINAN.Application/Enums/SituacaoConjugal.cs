using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum SituacaoConjugal
    {
        [Display(Name = "Solteiro")]
        Solteiro = 1,

        [Display(Name = "Casado / União consensual")]
        CasadoUniaoConsensual = 2,

        [Display(Name = "Viúvo")]
        Viuvo = 3,

        [Display(Name = "Separado")]
        Separado = 4,

        [Display(Name = "Não se Aplica")]
        NaoSeAplica = 8,

        [Display(Name = "Ignorado")]
        Ignorado = 9,
    }
}
