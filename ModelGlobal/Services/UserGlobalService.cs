using ModelGlobal.Data;
using ModelGlobal.Mapper;
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
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM User WHERE Id=@Id");
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<UserGlobal> Get()
        {
            Command command = new Command("Select * FROM User");
            //chaque ligne du reader est convertie au format user
            return _connection.ExecuteReader(command, u => u.ToUser());
        }

        public UserGlobal Get(int id)
        {
            Command command = new Command("Select * FROM User WHERE id=@id");
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, u => u.ToUser()).SingleOrDefault();
        }

        public int Post(UserGlobal user)
        {
            Command command = new Command
                ("INSERT INTO User (FirstName, LastName, Sex, DateOfBirth, Email, [Password]," +
                " RegistrationDate, [Address], Phone, [Role]) " +
                "output inserted.id VALUES " +
                "(@FirstName, @LastName, @Sex, @DateOfBirth, @Email, @[Password], @RegistrationDate, @[Address]," +
                " @Phone, @[Role]);");
            command.AddParameter("FirstName", user.FirstName);
            command.AddParameter("LastName", user.LastName);
            command.AddParameter("Sex", user.Sex);
            command.AddParameter("DateOfBirth", user.DateOfBirth);
            command.AddParameter("Email", user.Email);
            command.AddParameter("[Password]", user.Password);
            command.AddParameter("RegistrationDate", user.RegistrationDate);
            command.AddParameter("[Address]", user.Address);
            command.AddParameter("Phone", user.Phone);
            command.AddParameter("[Role]", user.Role);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, UserGlobal user)
        {
            Command command = new Command
                ("UPDATE User Set FirstName=@FirstName, LastName=@LastName, Sex=@Sex, DateOfBirth=@DateOfBirth, " +
                "Email=@Email, [Password]=@Password, RegistrationDate=@RegistrationDate, [Address]=@Address, " +
                "Phone=@Phone, [Role]=@Role WHERE id=@id");

            command.AddParameter("FirstName", user.FirstName);
            command.AddParameter("LastName", user.LastName);
            command.AddParameter("Sex", user.Sex);
            command.AddParameter("DateOfBirth", user.DateOfBirth);
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
