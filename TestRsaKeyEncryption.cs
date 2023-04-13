using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Duende.IdentityServer.Configuration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace RSAEncryptandDecrypt
{
    public class TestRsaKeyEncryption
    {

        private static string _privateKey = null!;
        private static string _publicKey = null!;

        public static void Test_RSA()
        {
            RSACryptoServiceProvider rsa = new();
            _privateKey = rsa.ToXmlString(true);
            _publicKey = rsa.ToXmlString(false);
            Console.WriteLine("Private Key: " + _privateKey + Environment.NewLine);
            Console.WriteLine("Public Key: " + _publicKey + Environment.NewLine);

            string text = "Stringa da Criptare@#[]123123";
            Console.WriteLine("Text to encrypt: " + Environment.NewLine + text + Environment.NewLine);
            string enc = Encrypt(text);
            Console.WriteLine("Encrypted Text: " + Environment.NewLine + enc + Environment.NewLine);
            string dec = Decrypt(enc);
            Console.WriteLine("Decrypted Text: " + Environment.NewLine + dec + Environment.NewLine);
        }

        private static string Encrypt(string data)
        {
            RSACryptoServiceProvider rsa = new();
            rsa.FromXmlString(_publicKey);

            byte[] dataToEncrypt = Encoding.ASCII.GetBytes(data);
            byte[] encryptedByteArray = rsa.Encrypt(dataToEncrypt, false).ToArray();

            return Convert.ToBase64String(encryptedByteArray);
        }

        private static string Decrypt(string data)
        {
            RSACryptoServiceProvider rsa = new();
            rsa.FromXmlString(_privateKey);

            byte[] dataByte = Convert.FromBase64String(data);
            byte[] decryptedByte = rsa.Decrypt(dataByte, false);

            return Encoding.UTF8.GetString(decryptedByte);
        }

    
    }
}
