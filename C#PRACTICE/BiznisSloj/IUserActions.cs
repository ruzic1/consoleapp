using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PRACTICE.BiznisSloj
{
    public interface IUserActions
    {
        void AddUser(string name, string email);
        void RemoveUser(string name);
        void ListUsers();
    }
}
