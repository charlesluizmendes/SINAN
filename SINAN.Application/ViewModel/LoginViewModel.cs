using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(255)]
        [EmailAddress]
        [Display(Name = "Login")]
        public string usu_email { get; set; }

        [Required]
        [MaxLength(32)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string usu_senha { get; set; }
    }
}