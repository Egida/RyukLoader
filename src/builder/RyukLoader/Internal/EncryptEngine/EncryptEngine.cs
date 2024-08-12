using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RyukLoader.Internal.EncryptEngine
{
    internal class EncryptEngine
    {
        public static void EncryptFile(string inputFile, string outputFile, string aesKey, string iv)
        {
            byte[] keyBytes = Convert.FromBase64String(aesKey);
            byte[] ivBytes = Convert.FromBase64String(iv);

            using (FileStream fileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            {
                using (FileStream encryptedFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                {
                    using (AesManaged aes = new AesManaged())
                    {
                        aes.KeySize = 256;
                        aes.Key = keyBytes;
                        aes.IV = ivBytes;
                        aes.Padding = PaddingMode.PKCS7;

                        using (CryptoStream cryptoStream = new CryptoStream(encryptedFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            fileStream.CopyTo(cryptoStream);
                        }
                    }
                }
            }
        }
        public static string EncryptStringToBase64(string plainText, string aesKeyBase64, string ivBase64)
        {
            byte[] key = Convert.FromBase64String(aesKeyBase64);
            byte[] iv = Convert.FromBase64String(ivBase64);
            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Key = key;
                aes.IV = iv;
                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        encrypted = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }
    }
}
