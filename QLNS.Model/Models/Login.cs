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

        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
    }
    public static class CredentialsSource
    {
        static System.Collections.Hashtable credentials;
        static CredentialsSource()
        {
            credentials = new System.Collections.Hashtable();
            credentials.Add("Guest", GetHash(null));
            credentials.Add("hantn", GetHash("123456"));
            credentials.Add("Admin", GetHash("admin1"));
        }
        public static bool Check(string login, string pwd)
        {
            return object.Equals(credentials[login], GetHash(pwd));
        }
        static object GetHash(string password)
        {
            return password;
        }
        public static System.Collections.Generic.IEnumerable<string> GetUserNames()
        {
            foreach (string item in credentials.Keys)
                yield return item;
        }
    }
}
