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
        public DateTime DateOfBirth { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public Role Role { get; set; }
        public string Salt { get; set; }

        public UserClient(){}

        public UserClient(int id, string firstName, string lastName, Sex sex, DateTime dateOfBirth, DateTime registrationDate, string address, string phone, string email, byte[] password, Role role, string salt)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            DateOfBirth = dateOfBirth;
            RegistrationDate = registrationDate;
            Address = address;
            Phone = phone;
            Email = email;
            Password = password;
            Role = role;
            Salt = salt;
        }
        public UserClient(string firstName, string lastName, Sex sex, DateTime dateOfBirth, DateTime registrationDate, string address, string phone, string email, byte[] password, Role role, string salt)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            DateOfBirth = dateOfBirth;
            RegistrationDate = registrationDate;
            Address = address;
            Phone = phone;
            Email = email;
            Password = password;
            Role = role;
            Salt = salt;
        }
    }
}
