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
        public int? assedio_sexual { get; set; }
        public int? estupro { get; set; }
        public int? pornorafia_infantil { get; set; }
        public int? exploracao_sexual { get; set; }
        public int? outros_violencia_sexual { get; set; }
        public string outros_violencia_sexual_extenso { get; set; }
        public int? profilaxia_dst { get; set; }
        public int? porfilaxia_hepatite_b { get; set; }
        public int? coleta_de_semen { get; set; }
        public int? contracepcao_de_emergencia { get; set; }
        public int? profilacia_hiv { get; set; }
        public int? coleta_de_sangue { get; set; }
        public int? coleta_de_secrecao_vaginal { get; set; }
        public int? aborto_previsto_em_lei { get; set; }
    }
}
