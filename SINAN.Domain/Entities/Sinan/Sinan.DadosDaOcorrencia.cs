using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{ 
    public class Sinan_DadosDaOcorrencia
    {
        public virtual int id { get; set; }
        public virtual string uf_ocorrencia { get; set; }
        public virtual double? mun_ocorrencia { get; set; }
        public virtual int? cod_ibge_ocorrencia { get; set; }
        public virtual string destrito_ocorrencia { get; set; }
        public virtual double? bairro_ocorrencia { get; set; }
        public virtual string lograd_ocorrencia { get; set; }
        public virtual int? cod_ocorrencia { get; set; }
        public virtual int? numero_ocorrencia { get; set; }
        public virtual string comp_ocorrencia { get; set; }
        public virtual string geo_campo3_ocorrencia { get; set; }
        public virtual string geo_campo4_ocorrencia { get; set; }
        public virtual string referencia_ocorrencia { get; set; }
        public virtual int? zona_ocorrencia { get; set; }
        public virtual string hora_ocorrencia { get; set; }
        public virtual int? local_ocorrencia { get; set; }
        public virtual int? ocorrencia_repetida { get; set; }
        public virtual int? autoprovocada { get; set; }
    }
}
