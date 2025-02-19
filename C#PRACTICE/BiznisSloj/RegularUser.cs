using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PRACTICE.BiznisSloj
{
    public class RegularUser:User
    {
        public RegularUser(string email,string password)
            :base(email,password)
        {

        }
        public override string ToString()
        {
            return "[REGULAR_USER]" + base.ToString();
        }
        //public override void DisplayUserInfo()
        //{
        //    Console.WriteLine($"[REGULAR_USER] Email:{Email}, Username:{Username}");
        //}
    }
}
