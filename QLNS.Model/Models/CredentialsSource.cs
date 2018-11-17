using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model.Models
{
    public static class CredentialsSource
    {
        static System.Collections.Hashtable credentials;
        static CredentialsSource()
        {
            credentials = new System.Collections.Hashtable();
            credentials.Add("Guest", GetHash(null));
            credentials.Add("hantn", GetHash("123456"));
            credentials.Add("admin", GetHash("1"));
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
