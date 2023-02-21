using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace AtlasShopping.Models
{
    class Users
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; } // TODO : How to create a password field in a class?
        
        public List<Product> orders;

        public Users(string name, string email, string address, string password, List<Product> orders)
        {
            Name = name;
            Email = email;
            Address = address;
            Password = password;
            this.orders = orders;
        }
    }
}
