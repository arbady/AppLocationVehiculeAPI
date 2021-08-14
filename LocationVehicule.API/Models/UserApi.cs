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

        public UserApi(int id, string firstName, string lastName, Sex sex, DateTime dateOfBirth, DateTime registrationDate, string address, string phone, string email, byte[] password, Role role, string salt)
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
    }
}
