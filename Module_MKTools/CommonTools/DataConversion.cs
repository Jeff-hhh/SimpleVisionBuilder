using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_MKTools
{
    /// <summary>
    /// 数据转换
    /// </summary>
    class DataConversion
    {
        /// <summary>
        /// 十六进制字符串转字节数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private byte[] HexStrToHexByte(string hexString)
        {
            byte[] returnBytes = new byte[hexString.Length / 2];
            try
            {
                hexString = hexString.Replace(" ", "");
                if ((hexString.Length % 2) != 0)
                {
                    hexString += " ";
                }
                for (int i = 0; i < returnBytes.Length; i++)
                {
                    returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                }
                return returnBytes;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
