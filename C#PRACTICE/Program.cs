using C_PRACTICE.BiznisSloj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PRACTICE
{
    class Program
    {
        //private string abc = "15";
        static void Main(string[] args)
        {
            IUserActions userManager=new UserManager();
            Console.WriteLine("Welcome to User management App");
            while (true)
            {
                
                Console.WriteLine("Press 1 for creating User");

                Console.WriteLine("Press 2 for listing users");

                Console.WriteLine("Press 3 for deleting User");

                string unos=Console.ReadLine();
                if (unos == "1")
                {

                    Console.WriteLine("Email:");
                    string email = Console.ReadLine();
                    Console.WriteLine("Username:");
                    string username = Console.ReadLine();
                    //userManager = new UserManager();
                    userManager.AddUser(email, username);
                    continue;
                }
                else if (unos == "2")
                {
                    Console.WriteLine("Prikaz svih korisnika:");
                    //userManager = new UserManager();
                    userManager.ListUsers();
                    //continue;

                }
            }
            //Console.WriteLine("Press 1 for creating User");
            //Console.ReadLine();
            
        }
        
    }
}
