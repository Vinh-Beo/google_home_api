using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Api.Common
{
    public class Base
    {
        public static void LOG(string data)
        {
            try
            {
                TextWriter file = new StreamWriter(HttpContext.Current.Server.MapPath("~/App_Data") + "\\" + UserConstant.LogPath + "_" + DateTime.Now.ToString("MMyyyy") + ".txt", true);

                file.WriteLine(DateTime.Now.ToString() + ":::" + data);
                file.Close();
            }
            catch
            {

            }
        }
        public static string GenKey()
        {
            string key;
            Random random = new Random();
            string chars = "abcdefghijklmnopqrstuvwxyz01";
            key = new string(Enumerable.Repeat(chars, 16)
            .Select(s => s[random.Next(s.Length)]).ToArray());
            return key;
        }

        public static string Decrypt(byte[] Cipher_Text, byte[] Key)
        {
            RijndaelManaged Crypto = null;
            MemoryStream MemStream = null;
            ICryptoTransform Decryptor = null;
            CryptoStream Crypto_Stream = null;
            StreamReader Stream_Read = null;
            string Plain_Text = "";

            try
            {
                Crypto = new RijndaelManaged();
                Crypto.KeySize = 128;
                Crypto.Mode = CipherMode.ECB;
                Crypto.Key = Key;
                Crypto.Padding = PaddingMode.None;
                MemStream = new MemoryStream(Cipher_Text);

                //Create Decryptor make sure if you are decrypting that this is here and you did not copy paste encrypt.
                Decryptor = Crypto.CreateDecryptor(Crypto.Key, Crypto.IV);

                //This is different from the encryption look at the mode make sure you are reading from the stream.
                Crypto_Stream = new CryptoStream(MemStream, Decryptor, CryptoStreamMode.Read);

                //I used the stream reader here because the ReadToEnd method is easy and because it return a string, also easy.
                Stream_Read = new StreamReader(Crypto_Stream);
                Plain_Text = Stream_Read.ReadToEnd();
            }
            finally
            {
                if (Crypto != null)
                    Crypto.Clear();
                if (MemStream != null)
                {
                    MemStream.Flush();
                    MemStream.Close();
                }
            }
            return Plain_Text.Trim('\0');
        }
        public static byte[] Encrypt(string Plain_Text, byte[] Key)
        {
            RijndaelManaged Crypto = null;
            MemoryStream MemStream = null;

            //I crypt transform is used to perform the actual decryption vs encryption, hash function are also a version of crypto transform.
            ICryptoTransform Encryptor = null;
            //Crypto streams allow for encryption in memory.
            CryptoStream Crypto_Stream = null;

            //Just grabbing the bytes since most crypt functions need bytes.
            byte[] pB = Encoding.UTF8.GetBytes(Plain_Text);
            int length = (pB.Length / 16 + (int)((pB.Length % 16 > 0) ? 1 : 0)) * 16;
            byte[] PlainBytes = new byte[length];

            for (int i = 0; i < pB.Length; i++)
            {
                PlainBytes[i] = pB[i];
            }
            try
            {
                Crypto = new RijndaelManaged();
                Crypto.KeySize = 128;
                Crypto.Mode = CipherMode.ECB;
                Crypto.Key = Key;
                Crypto.Padding = PaddingMode.None;
                MemStream = new MemoryStream();
                //Calling the method create encrypt method Needs both the Key and IV these have to be from the original Rijndael call
                //If these are changed nothing will work right.
                Encryptor = Crypto.CreateEncryptor(Crypto.Key, Crypto.IV);
                //The big parameter here is the cryptomode.write, you are writing the data to memory to perform the transformation
                Crypto_Stream = new CryptoStream(MemStream, Encryptor, CryptoStreamMode.Write);
                //The method write takes three params the data to be written (in bytes) the offset value (int) and the length of the stream (int)
                Crypto_Stream.Write(PlainBytes, 0, PlainBytes.Length);
            }
            finally
            {
                //if the crypt blocks are not clear lets make sure the data is gone
                if (Crypto != null)
                    Crypto.Clear();
                //Close because of my need to close things when done.
                Crypto_Stream.Close();
            }
            //Return the memory byte array
            return MemStream.ToArray();
        }
        public static long DateTimeToUnixTime(DateTime t)
        {
            DateTime sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (long)(t - sTime).TotalSeconds;
        }

        public static string CalculateMD5Hash(string input)

        {

            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);


            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {

                sb.Append(hash[i].ToString("x2"));
            }

            return sb.ToString();
        }
        public static bool HasSpecicalChar(string input)
        {
            if (input.Contains("+") ||
                input.Contains("`") ||
                input.Contains("~") ||
                input.Contains("!") ||
                input.Contains("@") ||
                input.Contains("#") ||
                input.Contains("$") ||
                input.Contains("%") ||
                input.Contains("^") ||
                input.Contains("&") ||
                input.Contains("*") ||
                input.Contains("?") ||
                input.Contains(";") ||
                input.Contains("\"") ||
                input.Contains("\'") ||
                input.Contains("=") ||
                input.Contains("<") ||
                input.Contains(">"))
            {
                return true;
            }
            return false;
        }
        public static bool HasPasswordSpecicalChar(string input)
        {
            if (input.Contains("+") ||
                input.Contains("&") ||
                input.Contains("=") ||
                input.Contains("?") ||
                input.Contains(";") ||
                input.Contains("\"") ||
                input.Contains("\'"))
            {
                return true;
            }
            return false;
        }
    }

    public class RequireParameterAttribute : ActionMethodSelectorAttribute
    {
        public RequireParameterAttribute(string parameterName) : this(new[] { parameterName })
        {
        }

        public RequireParameterAttribute(params string[] parameterNames)
        {
            ParameterNames = parameterNames;
            IncludeGET = true;
            IncludePOST = true;
            IncludeCookies = false;
            Mode = MatchMode.All;
        }

        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            switch (Mode)
            {
                case MatchMode.All:
                default:
                    return (
                        (IncludeGET && ParameterNames.All(p => controllerContext.HttpContext.Request.QueryString.AllKeys.Contains(p)))
                        || (IncludePOST && ParameterNames.All(p => controllerContext.HttpContext.Request.Form.AllKeys.Contains(p)))
                        || (IncludeCookies && ParameterNames.All(p => controllerContext.HttpContext.Request.Cookies.AllKeys.Contains(p)))
                        );
                case MatchMode.Any:
                    return (
                        (IncludeGET && ParameterNames.Any(p => controllerContext.HttpContext.Request.QueryString.AllKeys.Contains(p)))
                        || (IncludePOST && ParameterNames.Any(p => controllerContext.HttpContext.Request.Form.AllKeys.Contains(p)))
                        || (IncludeCookies && ParameterNames.Any(p => controllerContext.HttpContext.Request.Cookies.AllKeys.Contains(p)))
                        );
                case MatchMode.None:
                    return (
                        (!IncludeGET || !ParameterNames.Any(p => controllerContext.HttpContext.Request.QueryString.AllKeys.Contains(p)))
                        && (!IncludePOST || !ParameterNames.Any(p => controllerContext.HttpContext.Request.Form.AllKeys.Contains(p)))
                        && (!IncludeCookies || !ParameterNames.Any(p => controllerContext.HttpContext.Request.Cookies.AllKeys.Contains(p)))
                        );
            }
        }

        public string[] ParameterNames { get; private set; }

        /// <summary>
        /// Set it to TRUE to include GET (QueryStirng) parameters, FALSE to exclude them:
        /// default is TRUE.
        /// </summary>
        public bool IncludeGET { get; set; }

        /// <summary>
        /// Set it to TRUE to include POST (Form) parameters, FALSE to exclude them:
        /// default is TRUE.
        /// </summary>
        public bool IncludePOST { get; set; }

        /// <summary>
        /// Set it to TRUE to include parameters from Cookies, FALSE to exclude them:
        /// default is FALSE.
        /// </summary>
        public bool IncludeCookies { get; set; }

        /// <summary>
        /// Use MatchMode.All to invalidate the method unless all the given parameters are set (default).
        /// Use MatchMode.Any to invalidate the method unless any of the given parameters is set.
        /// Use MatchMode.None to invalidate the method unless none of the given parameters is set.
        /// </summary>
        public MatchMode Mode { get; set; }

        public enum MatchMode : int
        {
            All,
            Any,
            None
        }
    }
}