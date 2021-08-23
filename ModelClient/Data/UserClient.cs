using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class UserClient /*: UserGlobal*/
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }

        public UserClient(){}

        public UserClient(int id, string firstName, string lastName, Sex sex, DateTime birthDate, DateTime registrationDate, string address, string phone, string email, string password, Role role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            BirthDate = birthDate;
            RegistrationDate = registrationDate;
            Address = address;
            Phone = phone;
            Email = email;
            Password = password;
            Role = role;
        }
        public UserClient(string firstName, string lastName, Sex sex, DateTime birthDate, DateTime registrationDate, string address, string phone, string email, string password, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            BirthDate = birthDate;
            RegistrationDate = registrationDate;
            Address = address;
            Phone = phone;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
