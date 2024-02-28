using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Module_MKTools
{
    public class MD5Encrypt
    {
        #region[MD5加密]

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="plaintext">明文</param>
        /// <returns>加密后返回值</returns>
        public static string GetMD5String(string plaintext)
        {
            string md5string;
            try
            {
                MD5 md5 = MD5.Create();
                byte[] buffer = Encoding.Default.GetBytes(plaintext);
                byte[] md5buffer = md5.ComputeHash(buffer);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < md5buffer.Length; i++)
                {
                    sb.Append(md5buffer[i].ToString("x2"));
                }
                md5string = sb.ToString();
            }
            catch (Exception)
            {
                md5string = "";
                throw;
            }

            return md5string;
        }

        #endregion
    }
}
