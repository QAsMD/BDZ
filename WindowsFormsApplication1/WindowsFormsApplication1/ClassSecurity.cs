﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApplication1
{
    class ClassSecurity
    {
        public static string Encrypt(string plainText, string password, string salt = "Введисюдаченадо", string hashAlgorithm = "SHA1", int passwordIterations = 1, string initialVector = "OFRna73m*aze01xY",int keySize = 256)
        {
            if (string.IsNullOrEmpty(plainText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes (password, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] cipherTextBytes = null;

            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string cipherText, string password,string salt = "Введисюдаченадо", string hashAlgorithm = "SHA1",int passwordIterations = 1, string initialVector = "OFRna73m*aze01xY",int keySize = 256)
{
        if (string.IsNullOrEmpty(cipherText))
            return "";

        byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
        byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
        byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

        PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordIterations);
        byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);

        RijndaelManaged symmetricKey = new RijndaelManaged();
        symmetricKey.Mode = CipherMode.CBC;

        byte[] plainTextBytes = new byte[cipherTextBytes.Length];
        int byteCount = 0;

        using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initialVectorBytes))
        {
            using (MemoryStream memStream = new MemoryStream(cipherTextBytes))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                {
                    byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                    memStream.Close();
                    cryptoStream.Close();
                }
            }
        }

        symmetricKey.Clear();
        return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
    }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
