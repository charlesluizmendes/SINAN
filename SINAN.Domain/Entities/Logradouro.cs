using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Logradouro
    {
        public virtual int log_nu { get; set; }
        public virtual string ufe_sg { get; set; }
        public virtual int loc_nu { get; set; }
        public virtual int bai_nu_ini { get; set; }
        public virtual int? bai_nu_fim { get; set; }
        public virtual string log_no { get; set; }
        public virtual string log_complemento { get; set; }
        public virtual string cep { get; set; }
        public virtual string tlo_tx { get; set; }
        public virtual string log_sta_tlo { get; set; }
        public virtual string log_no_abrev { get; set; }
    }
}
