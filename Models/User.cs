using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace asp_net_project.Models
{
    public enum Role
    {
        Admin,
        User
    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public Role Role { get; set; }

        public static string HashPassword(string password) => 
            Convert.ToHexString(SHA512.HashData(Encoding.UTF8.GetBytes(password)));
    }
}
