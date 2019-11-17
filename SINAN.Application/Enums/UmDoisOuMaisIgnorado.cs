using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum UmDoisOuMaisIgnorado
    {
        [Display(Name = "Um")]
        Um = 1,

        [Display(Name = "Dois ou mais")]
        DoisOuMais = 2,

        [Display(Name = "Ignorado")]
        Ignorado = 9,
    }
}
