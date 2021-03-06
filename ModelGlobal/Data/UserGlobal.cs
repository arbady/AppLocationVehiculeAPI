using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal.Data
{
    public class UserGlobal
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //public string RePassword { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Role Role { get; set; }
    }
}
