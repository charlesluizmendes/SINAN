using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_DadosDePessoaAtendida
    {
        public virtual int id { get; set; }
        public virtual string nome_social { get; set; }
        public virtual string ocupacao { get; set; }
        public virtual int? situacao_conjugal { get; set; }
        public virtual int? orientacao_sexual { get; set; }
        public virtual int? identidade_genero { get; set; }
        public virtual int? deficiencia { get; set; }
        public virtual int? deficiencia_fisica { get; set; }
        public virtual int? deficiencia_visual { get; set; }
        public virtual int? transtorno_mental { get; set; }
        public virtual int? deficiencia_intelectual { get; set; }
        public virtual int? deficiencia_auditiva { get; set; }
        public virtual int? trans_de_comportamento { get; set; }
        public virtual int? deficiencia_outros { get; set; }
        public virtual string deficiencia_outros_extenso { get; set; }

    }
}
