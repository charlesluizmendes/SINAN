using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum RedeEnsino
    {
        [Display(Name = "Pública")]
        Publica = 1,

        [Display(Name = "Privada")]
        Privada = 2,
    }
}
