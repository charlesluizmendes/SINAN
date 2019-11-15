using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum Sexo
    {
        [Display(Name = "Masculino")]
        M = 'M',

        [Display(Name = "Feminino")]
        F = 'F',

        [Display(Name = "Ignorado")]
        I = 'I'
    }
}
