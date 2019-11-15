using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace SINAN.Infrastructure.CrossCutting.Helpers
{
    public class MD5Hash
    {
        public static string GetMd5Hash(string input)
        {
            if (!String.IsNullOrEmpty(input))
            {
                MD5 md5 = MD5.Create();

                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }

                return sb.ToString();
            }
            else
            {
                return String.Format("", input);
            }
        }
    }
}