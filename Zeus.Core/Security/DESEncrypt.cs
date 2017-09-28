using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Zeus.Core
{
    /// <summary>
    /// DES加密、解密帮助类
    /// </summary>
    public class DESEncrypt
    {
        private static string DESKey = "zeus_desencrypt_2016";


        #region ========加密========
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Encrypt(string Text)
        {
            return Encrypt(Text, DESKey);
        }
        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="strText"></param> 
        /// <param name="strEncrKey"></param> 
        /// <returns></returns> 
        public static string Encrypt(string strText, string strEncrKey)
        {
            //DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            //byte[] inputByteArray;
            //inputByteArray = Encoding.Default.GetBytes(strText);
            //des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(strEncrKey, "md5").Substring(0, 8));
            //des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(strEncrKey, "md5").Substring(0, 8));
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            //cs.Write(inputByteArray, 0, inputByteArray.Length);
            //cs.FlushFinalBlock();
            //StringBuilder ret = new StringBuilder();
            //foreach (byte b in ms.ToArray())
            //{
            //    ret.AppendFormat("{0:X2}", b);
            //}
            //return ret.ToString();
            byte[] byKey = { };
            byte[] IV = new byte[] { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            byKey = Encoding.UTF8.GetBytes(strEncrKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(strText);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }

        #endregion

        #region ========解密========
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Decrypt(string Text)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                return Decrypt(Text, DESKey);
            }
            else
            {
                return "";
            }
        }
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="strText"></param> 
        /// <param name="sDecrKey"></param> 
        /// <returns></returns> 
        public static string Decrypt(string strText, string sDecrKey)
        {
            //DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            //int len;
            //len = strText.Length / 2;
            //byte[] inputByteArray = new byte[len];
            //int x, i;
            //for (x = 0; x < len; x++)
            //{
            //    i = Convert.ToInt32(strText.Substring(x * 2, 2), 16);
            //    inputByteArray[x] = (byte)i;
            //}
            //des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sDecrKey, "md5").Substring(0, 8));
            //des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sDecrKey, "md5").Substring(0, 8));
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            //cs.Write(inputByteArray, 0, inputByteArray.Length);
            //cs.FlushFinalBlock();
            //return Encoding.Default.GetString(ms.ToArray());

            byte[] byKey = { };
            byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            byte[] inputByteArray = new byte[strText.Length];
            byKey = Encoding.UTF8.GetBytes(sDecrKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            inputByteArray = Convert.FromBase64String(strText);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            Encoding encoding = Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }

        #endregion
    }
}
