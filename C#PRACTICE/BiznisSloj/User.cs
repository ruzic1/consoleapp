using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PRACTICE.BiznisSloj
{
    public abstract class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private string username;

        public string Email
        {
            get { return email; }
            set
            {
                this.email = value;
            }
        }
        public string Username
        {
            get { return username; }
            set
            {
                this.username = value;
            }
        }
        public User(string email,string username)
        {
            this.email = email;
            this.username = username;
        }

        //public abstract void DisplayUserInfo();
        public override string ToString()
        {
            return $"Email:{Email}, Username:{Username}";
        }
    }
}
