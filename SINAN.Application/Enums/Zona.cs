using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum Zona
    {
        [Display(Name = "Urbana")]
        Urbana = 1,

        [Display(Name = "Rural")]
        Rural = 2,

        [Display(Name = "Periurbana")]
        Periurbana = 3,

        [Display(Name = "Ignorado")]
        Ignorado = 9
    }
}
