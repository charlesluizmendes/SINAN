using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum SexoProvavelAutorViolencia
    {
        [Display(Name = "Masculino")]
        Masculino = 1,

        [Display(Name = "Feminino")]
        Feminino = 2,

        [Display(Name = "Ambos os sexos")]
        AmbosOsSexos = 3,

        [Display(Name = "Ignorado")]
        Ignorado = 9,
    }
}
