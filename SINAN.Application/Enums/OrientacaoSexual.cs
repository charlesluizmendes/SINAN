using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum OrientacaoSexual
    {
        [Display(Name = "Heterossexual")]
        Heterossexual = 1,

        [Display(Name = "Homossexual(gay/lésbica)")]
        Homossexual = 2,

        [Display(Name = "Bissexual")]
        Bissexual = 3,

        [Display(Name = "Não se Aplica")]
        NaoSeAplica = 8,

        [Display(Name = "Ignorado")]
        Ignorado = 9,
    }
}
