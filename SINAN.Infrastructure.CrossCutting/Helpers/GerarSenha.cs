using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace SINAN.Infrastructure.CrossCutting.Helpers
{
    public class GerarSenha
    {
        public static string GetGeneratePassword()
        {
            string pw = Membership.GeneratePassword(10, 0);

            return pw;
        }
    }
}
