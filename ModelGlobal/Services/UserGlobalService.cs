using ModelGlobal.Data;
using ModelGlobal.Mapper;
using ModelGlobal.Services.Bases;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ModelGlobal.Services
{
    public class UserGlobalService : BaseService, IRepoUser<UserGlobal>
    {
        public UserGlobal Check(string mail, string password)
        {
            Command command = new Command(
                "SELECT * FROM [User] WHERE email=@email AND password=dbo.SF_HashingPassword(@password, Salt)"); //A voir
            command.AddParameter("email", mail);
            command.AddParameter("password", password);
            return _connection.ExecuteReader(command, u => u.ToUser()).SingleOrDefault();
        }
        public bool Delete(int id)
        {
            Command command = new Command("SP_DeleteUser", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<UserGlobal> Get()
        {
            Command command = new Command("SP_GetAllUser", true);
            //chaque ligne du reader est convertie au format user
            return _connection.ExecuteReader(command, u => u.ToUser());
        }

        public UserGlobal Get(int id)
        {
            Command command = new Command("SP_GetByIdUser", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, u => u.ToUser()).SingleOrDefault();
        }

        public int Post(UserGlobal user)
        {
            Command command = new Command("SP_InsertUser", true);
            command.AddParameter("firstName", user.FirstName);
            command.AddParameter("lastName", user.LastName);
            command.AddParameter("sex", user.Sex);
            command.AddParameter("birthDate", user.BirthDate);
            command.AddParameter("email", user.Email);
            command.AddParameter("password", user.Password);
            command.AddParameter("registrationDate", user.RegistrationDate);
            command.AddParameter("address", user.Address);
            command.AddParameter("phone", user.Phone);
            command.AddParameter("role", user.Role);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, UserGlobal user)
        {
            Command command = new Command("SP_UpdateUser", true);

            command.AddParameter("FirstName", user.FirstName);
            command.AddParameter("LastName", user.LastName);
            command.AddParameter("Sex", user.Sex);
            command.AddParameter("DateOfBirth", user.BirthDate);
            command.AddParameter("Email", user.Email);
            command.AddParameter("[Password]", user.Password);
            command.AddParameter("RegistrationDate", user.RegistrationDate);
            command.AddParameter("[Address]", user.Address);
            command.AddParameter("Phone", user.Phone);
            command.AddParameter("[Role]", user.Role);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
