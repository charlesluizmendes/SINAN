﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Application.Enums
{
    public enum Perfil
    {
        [Display(Name = "Operador")]
        Operador = 1,

        [Display(Name = "Administrador")]
        Administrador = 2
    }
}