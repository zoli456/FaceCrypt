﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace FaceCrypt
{
    internal static class Data
    {
        internal static IniHandler personal_ini;

        internal static string verifieduser;
        internal static string facesdata_folder = "TrainedFaces";
        internal static readonly string facename_data = "images.txt";
        internal static string profil_data = "Profiles.txt";
        internal static string settings_ini = "Settings.ini";
        internal static string password_location = "secret.txt";
        internal static TimeSpan logouttime;
        internal static TimeSpan logouttimer;
        internal static bool autologout = true;
        internal static bool logout_voice;
        internal static bool shutdown_voice;
        internal static bool hibernate_voice;
        internal static bool restart_voice;
    }

    internal class IniHandler
    {
        public string path;

        public IniHandler(string INIPath)
        {
            path = INIPath;
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal,
            int size, string filePath);

        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, path);
        }

        public string IniReadValue(string Section, string Key)
        {
            var temp = new StringBuilder(255);
            var i = GetPrivateProfileString(Section, Key, "", temp, 255, path);
            return temp.ToString();
        }
    }

    public class Crypto
    {
        private static readonly byte[] _salt = Encoding.ASCII.GetBytes("o6806642kbM7c5");

        /// <summary>
        ///     Encrypt the given string using AES.  The string can be decrypted using
        ///     DecryptStringAES().  The sharedSecret parameters must match.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for encryption.</param>
        internal static string EncryptStringAES(string plainText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException("plainText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            string outStr = null; // Encrypted string to return
            RijndaelManaged aesAlg = null; // RijndaelManaged object used to encrypt the data.

            try
            {
                // generate the key from the shared secret and the salt
                var key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create a RijndaelManaged object
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                // Create a decryptor to perform the stream transform.
                var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (var msEncrypt = new MemoryStream())
                {
                    // prepend the IV
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }

                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            // Return the encrypted bytes from the memory stream.
            return outStr;
        }

        /// <summary>
        ///     Decrypt the given string.  Assumes the string was encrypted using
        ///     EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
        public static string DecryptStringAES(string cipherText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
            RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            try
            {
                // generate the key from the shared secret and the salt
                var key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create the streams used for decryption.                
                var bytes = Convert.FromBase64String(cipherText);
                using (var msDecrypt = new MemoryStream(bytes))
                {
                    // Create a RijndaelManaged object
                    // with the specified key and IV.
                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    // Get the initialization vector from the encrypted stream
                    aesAlg.IV = ReadByteArray(msDecrypt);
                    // Create a decrytor to perform the stream transform.
                    var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            var rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
                throw new SystemException("Stream did not contain properly formatted byte array");

            var buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
                throw new SystemException("Did not read byte array properly");

            return buffer;
        }
    }
}