using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class AlterarSenhaViewModel
    {
        [Required, MaxLength(32)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha Atual")]
        public string usu_senha_anterior { get; set; }

        [Required, MaxLength(32)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova Senha")]
        public string usu_senha { get; set; }

        [Required, MaxLength(32)]
        [DataType(DataType.Password)]
        [Compare("usu_senha", ErrorMessage = "As senhas são diferentes")]
        [Display(Name = "Confirmar Senha")]
        public string usu_senha_confirma { get; set; }
    }
}