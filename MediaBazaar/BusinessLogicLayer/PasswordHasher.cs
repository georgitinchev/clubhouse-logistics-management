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
            return BCrypt.Net.BCrypt.GenerateSalt();
            
        }

        public string HashPassword(string password, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(password + salt);
        }

        public string DeHashedPassword(string password, string salt)
        {
            return BCrypt.Net.BCrypt.GenerateSalt();
        }


    }
}
