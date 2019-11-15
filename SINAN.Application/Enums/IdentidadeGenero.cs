using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum IdentidadeGenero
    {
        [Display(Name = "Travesti")]
        Travesti = 1,

        [Display(Name = "Mulher Transexual")]
        MulherTransexual = 2,

        [Display(Name = "Homem Transexual")]
        HomemTransexual = 3,

        [Display(Name = "Não se aplica")]
        NãoSeAplica = 8,

        [Display(Name = "Ignorado")]
        Ignorado = 9,
    }
}
