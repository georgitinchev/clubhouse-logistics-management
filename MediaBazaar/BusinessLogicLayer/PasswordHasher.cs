using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PasswordHasher
    {
        public  string GenerateSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        public string HashPassword(string password, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(password + salt);
        }
    }
}
