using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class RecuperarSenhaViewModel
    {
        [Required]
        [MaxLength(14)]
        [RegularExpression(@"[0-9]{3}\.[0-9]{3}\.[0-9]{3}-[0-9]{2}", ErrorMessage = "Digite um CPF válido")]
        [Display(Name = "CPF")]
        public string usu_cpf { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        [Display(Name = "Login")]
        public string usu_email { get; set; }
    }
}