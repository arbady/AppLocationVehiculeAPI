using ModelClient.Data;
using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class UserApi : UserClient
    {

        public UserApi(int id, string firstName, string lastName, Sex sex, DateTime birthDate, DateTime registrationDate, string address, string phone, string email, string password, Role role)
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
    }
}
