using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINAN.Application.Enums;

namespace SINAN.Application.ViewModel
{
    public class Sinan_ViolenciaSexualViewModel
    {
        [Display(Name = "Assédio sexual")]
        public SimNaoNaoSeAplicaIgnorado? assedio_sexual { get; set; }

        [Display(Name = "Estupro")]
        public SimNaoNaoSeAplicaIgnorado? estupro { get; set; }

        [Display(Name = "Pornografia Infantil")]
        public SimNaoNaoSeAplicaIgnorado? pornorafia_infantil { get; set; }

        [Display(Name = "Exploração sexual")]
        public SimNaoNaoSeAplicaIgnorado? exploracao_sexual { get; set; }

        [Display(Name = "Outros")]
        public SimNaoNaoSeAplicaIgnorado? outros_violencia_sexual { get; set; }

        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome Social válido")]
        public string outros_violencia_sexual_extenso { get; set; }

        [Display(Name = "Profilaxia DST")]
        public SimNaoNaoSeAplicaIgnorado? profilaxia_dst { get; set; }

        [Display(Name = "Profilaxia Hepatite B")]
        public SimNaoNaoSeAplicaIgnorado? porfilaxia_hepatite_b { get; set; }

        [Display(Name = "Coleta de sêmen")]
        public SimNaoNaoSeAplicaIgnorado? coleta_de_semen { get; set; }

        [Display(Name = "Contracepção de emergência")]
        public SimNaoNaoSeAplicaIgnorado? contracepcao_de_emergencia { get; set; }

        [Display(Name = "Profilaxia HIV")]
        public SimNaoNaoSeAplicaIgnorado? profilacia_hiv { get; set; }

        [Display(Name = "Celeta de sangue")]
        public SimNaoNaoSeAplicaIgnorado? coleta_de_sangue { get; set; }

        [Display(Name = "Coleta de secreção vaginal")]
        public SimNaoNaoSeAplicaIgnorado? coleta_de_secrecao_vaginal { get; set; }

        [Display(Name = "Aborto previsto em lei")]
        public SimNaoNaoSeAplicaIgnorado? aborto_previsto_em_lei { get; set; }
    }
}
