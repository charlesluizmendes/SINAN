using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_ViolenciaSexual
    {
        public virtual int id { get; set; }
        public virtual int? assedio_sexual { get; set; }
        public virtual int? estupro { get; set; }
        public virtual int? pornorafia_infantil { get; set; }
        public virtual int? exploracao_sexual { get; set; }
        public virtual int? outros_violencia_sexual { get; set; }
        public virtual string outros_violencia_sexual_extenso { get; set; }
        public virtual int? profilaxia_dst { get; set; }
        public virtual int? porfilaxia_hepatite_b { get; set; }
        public virtual int? coleta_de_semen { get; set; }
        public virtual int? contracepcao_de_emergencia { get; set; }
        public virtual int? profilacia_hiv { get; set; }
        public virtual int? coleta_de_sangue { get; set; }
        public virtual int? coleta_de_secrecao_vaginal { get; set; }
        public virtual int? aborto_previsto_em_lei { get; set; }
    }
}
