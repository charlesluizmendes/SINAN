using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Sinan_Observacoes
    {
        public virtual int id { get; set; }
        public virtual string nome_acompanhate { get; set; }
        public virtual string vinculo_acompanhate { get; set; }
        public virtual string telefone_acompanhate { get; set; }
        public virtual string obs { get; set; }
    }
}
