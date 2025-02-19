using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PRACTICE.BiznisSloj
{
    public class GuestUser:User
    {

        public GuestUser(string email, string username)
            :base(email,username)
        {

        }
        public override string ToString()
        {
            return "[GUEST]"+base.ToString();
        }
        //public override void DisplayUserInfo()
        //{
        //    Console.WriteLine($"[GUEST] Email:{Email}, Username:{Username}");
        //}
    }
}
