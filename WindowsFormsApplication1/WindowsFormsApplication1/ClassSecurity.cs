using System;
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
        public static string Encrypt(string plainText, string password, string user_IV = "magic_great_dead_or_alive")
        {
            string correct_password = "";
            string IV = "";
            string correct_text = plainText;
            byte[] encrypted;

            if (password.Length != 32)
            {
                while (true)
                {
                    correct_password += password;
                    if (correct_password.Length > 32)
                    {
                        correct_password = correct_password.Substring(0, 32);
                        break;
                    }
                }
            }

            if (user_IV.Length != 16)
            {
                while (true)
                {
                    IV += user_IV;
                    if (IV.Length > 16)
                    {
                        IV = IV.Substring(0, 16);
                        break;
                    }
                }
            }

            byte[] byte_password = Encoding.Default.GetBytes(correct_password);
            byte[] byte_IV = Encoding.Default.GetBytes(IV);

            Aes aes_alg = Aes.Create();
            aes_alg.Mode = CipherMode.CBC;
            aes_alg.BlockSize = 128;
            aes_alg.IV = byte_IV;
            aes_alg.Key = byte_password;

            ICryptoTransform encryptor = aes_alg.CreateEncryptor();

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        //Write all data to the stream.
                        swEncrypt.Write(correct_text);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string plainText, string password, string user_IV = "magic_great_dead_or_alive")
        {
            string correct_password = "";
            string IV = "";
            string correct_text = plainText;

            if (password.Length != 32)
            {
                while (true)
                {
                    correct_password += password;
                    if (correct_password.Length > 32)
                    {
                        correct_password = correct_password.Substring(0, 32);
                        break;
                    }
                }
            }

            if (user_IV.Length != 16)
            {
                while (true)
                {
                    IV += user_IV;
                    if (IV.Length > 16)
                    {
                        IV = IV.Substring(0, 16);
                        break;
                    }
                }
            }

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;
            byte[] byte_password = Encoding.Default.GetBytes(correct_password);
            byte[] byte_IV = Encoding.Default.GetBytes(IV);
            byte[] text = Convert.FromBase64String(plainText);
            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = byte_password;
                aesAlg.IV = byte_IV;
                aesAlg.Mode = CipherMode.CBC;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(text))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting 
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }
            return plaintext;
        }
    }
}
