using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAN.Domain.Entities
{
    public class Bairro
    {
        public virtual double bai_nu { get; set; }
        public virtual string ufe_sg { get; set; }
        public virtual double loc_nu { get; set; }
        public virtual string bai_no { get; set; }
        public virtual string bai_no_abrev { get; set; }
    }
}
