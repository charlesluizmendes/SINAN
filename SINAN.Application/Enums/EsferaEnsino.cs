using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum EsferaEnsino
    {
        [Display(Name = "Municipal")]
        Municipal = 1,

        [Display(Name = "Estadual")]
        Estadual = 2,

        [Display(Name = "Federal")]
        Federal = 3,
    }
}
