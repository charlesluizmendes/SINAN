using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Unidade
    {
        public virtual int id { get; set; }
        public virtual string cnes { get; set; }
        public virtual string cpf_cnpj { get; set; }
        public virtual string fantasia { get; set; }
        public virtual string codufmun_old { get; set; }
        public virtual string codufmun { get; set; }
    }
}
