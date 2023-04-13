using System.Text;
using System.Diagnostics;
using System.Security.Cryptography;




namespace RSAEncryptandDecrypt
{
    public class Passwordsalt
    {

        public static byte[] GenerateSalt()
        {
            const int saltLength = 32;

            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[saltLength];
                randomNumberGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }

        public void HashPasswords(string passwordToHash, int numberOfRounds)
        {
            var sw = new Stopwatch();
            byte[] salt = GenerateSalt();
            sw.Start();
            var hashedPassword = HashPassword(Encoding.UTF8.GetBytes(passwordToHash), salt, numberOfRounds);
            sw.Stop();

            Console.WriteLine("Password to hash : " + passwordToHash);
            Console.WriteLine("Generated Salt : " + Convert.ToBase64String(salt));
            Console.WriteLine("PBKDF2 Hashed Password : " + Convert.ToBase64String(hashedPassword));
            Console.WriteLine("Iterations : " + numberOfRounds);
            Console.WriteLine("Elapsed Time : " + sw.ElapsedMilliseconds + "ms");
            Console.WriteLine();
        }
        public static byte[] HashPassword(byte[] toBeHashed, byte[] salt, int numberOfRounds)
        {
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(toBeHashed, salt, numberOfRounds))
            {
                return rfc2898DeriveBytes.GetBytes(32);
            }
        }

    }
}
