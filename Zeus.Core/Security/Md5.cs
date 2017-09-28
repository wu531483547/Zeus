using System.Security.Cryptography;
using System.Text;

namespace Zeus.Core
{
    public class Md5
    {
        //#region MD5加密
        ///// <summary>
        ///// MD5加密
        ///// </summary>
        ///// <param name="str">加密字符</param>
        ///// <param name="code">加密位数16/32</param>
        ///// <returns></returns>
        //public static string md5(string str, int code)
        //{
        //    string strEncrypt = string.Empty;
        //    if (code == 16)
        //    {
        //        strEncrypt = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").Substring(8, 16);
        //    }
        //    if (code == 32)
        //    {
        //        strEncrypt = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
        //    }
        //    return strEncrypt;
        //}
        //#endregion

        /// <summary>
        /// 16位MD5加密
        /// </summary>
        /// <param name="rawPass">源字符串</param>
        /// <returns>加密后字符串</returns>
        public static string MD5_16(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bs = Encoding.UTF8.GetBytes(str);
            byte[] hs = md5.ComputeHash(bs);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hs)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 32位MD5加密
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string MD5_32(string str)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(str));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
