using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PRACTICE.BiznisSloj
{
    public class UserManager:IUserActions
    {
        private List<User> users = new List<User>();
        public void AddUser(string email,string username)
        {
            users.Add(new RegularUser(email, username));
        }
        public void RemoveUser(string name)
        {
            string abc = name;
        }
        public void ListUsers()
        {
            //Console.WriteLine("AJOWFIJ");
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
            //string abc = "15";
        }
    }
}
