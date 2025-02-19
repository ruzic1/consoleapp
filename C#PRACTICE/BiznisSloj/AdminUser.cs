using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PRACTICE.BiznisSloj
{
    public class AdminUser:User
    {
        public AdminUser(string email,string username)
            :base(email, username)
        {
            
        }
        public override string ToString()
        {
            return "[ADMIN]" + base.ToString();
        }
        //public override void DisplayUserInfo()
        //{
        //    Console.WriteLine($"[ADMIN] Email:{Email}, Username:{Username}");
        //}
    }
}
