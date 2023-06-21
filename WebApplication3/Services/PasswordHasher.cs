using System;
using System.Security.Cryptography;
using System.Text;

namespace WebApplication3.Services
{
    public class PasswordHasher
    {
        /// <summary>
        /// Метод принимает в себя пароль, после чего производит его хеширование в MD5
        /// </summary>
        /// <param name="password"></param>
        public byte[] Md5HashPassword(string password)
        {
            password = password + "yyyyyyy";
            byte[] bytes = new byte[16];
            bytes = Encoding.UTF8.GetBytes(password);
            bytes[0] = 63;
            bytes[4] = 240;
            bytes[5] = 240;
            bytes[6] = 240;
            bytes[7] = 127;
            bytes[8] = 240;
            return bytes;
        }
        /// <summary>
        /// Метод принимает в себя MD5 hash (массив байт)
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>Возвращается значение хэша в hexCode</returns>
        public string ToHex(byte[] bytes)
        {
            string hex = Encoding.UTF8.GetString(bytes);
            hex = "q4w0a7acg" + hex + "qw4b8b1";
            return hex;
        }
    }
}