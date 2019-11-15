using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_DadosResidencia
    {
        public virtual int id { get; set; }
        public virtual string uf_residencia { get; set; }
        public virtual double? municipio_residencia { get; set; }
        public virtual int? cod_ibge_residencia { get; set; }
        public virtual string distrito_residencia { get; set; }
        public virtual double? bairro_residencia { get; set; }
        public virtual string logradouro_residencia { get; set; }
        public virtual int? cod_residencia { get; set; }
        public virtual int? numero_residencia { get; set; }
        public virtual string comp_residencia { get; set; }
        public virtual string geo_campo1_residencia { get; set; }
        public virtual string geo_campo2_residencia { get; set; }
        public virtual string referencia_residencia { get; set; }
        public virtual string cep { get; set; }
        public virtual string telefone { get; set; }
        public virtual int? zona { get; set; }
        public virtual string pais { get; set; }

    }
}
