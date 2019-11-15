using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class CriarContaViewModel
    {
        [Required]
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome válido")]
        [Display(Name = "Nome")]
        public string usu_nome { get; set; }

        [Required]
        [MaxLength(14)]
        [RegularExpression(@"[0-9]{3}\.[0-9]{3}\.[0-9]{3}-[0-9]{2}", ErrorMessage = "Digite um CPF válido")]
        [Display(Name = "CPF")]
        public string usu_cpf { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string usu_email { get; set; }

        [Required]
        [MaxLength(17)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string usu_telefone { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "O campo Perfil é obrigatório.")]
        [Display(Name = "Perfil")]
        public Perfil usu_perfil { get; set; }

        [Required]
        [MaxLength(32)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string usu_senha { get; set; }

        [Required]
        [MaxLength(32)]
        [DataType(DataType.Password)]
        [Compare("usu_senha", ErrorMessage = "As senhas são diferentes")]
        [Display(Name = "Confirmar Senha")]
        public string usu_senha_confirma { get; set; }
    }
}