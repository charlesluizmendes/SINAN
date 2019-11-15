using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Municipio
    {
        public virtual double loc_un { get; set; }
        public virtual string ufe_sg { get; set; }
        public virtual string loc_no { get; set; }
        public virtual string cep { get; set; }
        public virtual string loc_in_sit { get; set; }
        public virtual string loc_in_tipo_loc { get; set; }
        public virtual string loc_nu_sub { get; set; }
        public virtual string loc_no_abrev { get; set; }
        public virtual string mun_nu { get; set; }
    }
}
