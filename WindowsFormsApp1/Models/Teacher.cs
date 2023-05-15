using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Teacher : Person
    {
        public string Username { get; set; }
        protected string Password { get; set; }

        public bool CheckPassword(string password) {
            return Password == password;
        }
    }
}
