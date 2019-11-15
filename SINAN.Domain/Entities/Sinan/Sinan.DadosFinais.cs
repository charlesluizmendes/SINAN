using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_DadosFinais
    {
        public virtual int id { get; set; }
        public virtual int violencia_trabalho { get; set; }
        public virtual int? emissao_cat { get; set; }
        public virtual string circunstancia_lesao { get; set; }
        public virtual DateTime? data_encerramento { get; set; }
    }
}
