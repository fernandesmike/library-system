using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LibrarySystem
{
    class PasswordHandler
    {
        private const int SaltByteSize = 24;
        private const int HashByteSize = 20; // to match the size of the PBKDF2-HMAC-SHA-1 hash 
        private const int Pbkdf2Iterations = 1000;

        // Used for checking password hashes
        private const int IterationIndex = 0;
        private const int SaltIndex = 1;
        private const int Pbkdf2Index = 2;

        // Method to generate a salt and returns the final salted hashed password
        public static string HashPassword(string password)
        {
            // We need this class to get access to getBytes() method
            var cryptoProvider = new RNGCryptoServiceProvider();

            // Create an array of bytes with the specified size
            byte[] salt = new byte[SaltByteSize];

            // This method returns a cryptograpically strong sequence of random values
            cryptoProvider.GetBytes(salt);

            // Invoke the GetPbkdf2Bytes method
            var hash = GetPbkdf2Bytes(password, salt, Pbkdf2Iterations, HashByteSize);

            // Return the 64-base digit string equivalent of byte variable salt and byte variable hash
            return Pbkdf2Iterations + ":" +
                   Convert.ToBase64String(salt) + ":" +
                   Convert.ToBase64String(hash);
        }

        // Method that supplies the necessary arguments for the SlowEquals() method and
        // returns boolean if both hashes matched
        public static bool ValidatePassword(string password, string correctHash)
        {
            char[] delimiter = { ':' };
            var split = correctHash.Split(delimiter);
            var iterations = Int32.Parse(split[IterationIndex]);
            var salt = Convert.FromBase64String(split[SaltIndex]);
            var hash = Convert.FromBase64String(split[Pbkdf2Index]);

            var testHash = GetPbkdf2Bytes(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        // Method to check the hashes
        private static bool SlowEquals(byte[] a, byte[] b)
        {
            var diff = (uint)a.Length ^ (uint)b.Length;

            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }
            return diff == 0;
        }

        // Method to generate a salted hash, should only be available inside the class
        private static byte[] GetPbkdf2Bytes(string password, byte[] salt, int iterations, int outputBytes)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            return pbkdf2.GetBytes(outputBytes);
        }

    }
}
