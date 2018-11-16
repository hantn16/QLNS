using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [MinLength(4)]
        [MaxLength(16)]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        [Display(Name = "Mật khẩu")]
        [MinLength(6)]
        public string Password { get; set; }
    }
    static class CredentialsSource
    {
        static System.Collections.Hashtable credentials;
        static CredentialsSource()
        {
            credentials = new System.Collections.Hashtable();
            credentials.Add("Guest", GetHash(null));
            credentials.Add("hantn", GetHash("123456"));
            credentials.Add("Admin", GetHash("admin1"));
        }
        internal static bool Check(string user, string pwd)
        {
            return object.Equals(credentials[user], GetHash(pwd));
        }
        static object GetHash(string password)
        {
            return password;
        }
        internal static System.Collections.Generic.IEnumerable<string> GetUserNames()
        {
            foreach (string item in credentials.Keys)
                yield return item;
        }
    }
}
