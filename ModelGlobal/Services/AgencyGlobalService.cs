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
    public class AgencyGlobalService : BaseService, IRepoAgency<AgencyGlobal>
    {
        //private Connection _connection;
        //private string _conStr = @"Data Source=LAPTOP-VIA3UD35;Initial Catalog=AppLocationVehicule;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //public AgencyGlobalService()
        //{
        //    _connection = new Connection(_conStr);
        //}

        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Agency WHERE Id=@Id");
            //Command command = new Command(isStoredProcedure);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<AgencyGlobal> Get()
        {
            Command command = new Command("Select * FROM Agency");
            //chaque ligne du reader est convertie au format agencyGlobal
            return _connection.ExecuteReader(command, a => a.ToAgency());
        }

        public AgencyGlobal Get(int id)
        {
            Command command = new Command("Select * FROM Agency WHERE id=@id");
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, a => a.ToAgency()).SingleOrDefault();
        }

        public int Post(AgencyGlobal agency)
        {
            Command command = new Command
                ("INSERT INTO Agency (Code, Airport, [Address], ZipCode, City, Country, IsClosed) " +
                "output inserted.id VALUES " +
                "(@Code, @Airport, @Address, @ZipCode, @City, @Country, @IsClosed);");
            command.AddParameter("Code", agency.Code);
            command.AddParameter("Airport", agency.Airport);
            command.AddParameter("Address", agency.Address);
            command.AddParameter("ZipCode", agency.ZipCode);
            command.AddParameter("City", agency.City);
            command.AddParameter("Country", agency.Country);
            command.AddParameter("IsClosed", agency.IsClosed);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, AgencyGlobal agency)
        {
            Command command = new Command
                ("UPDATE Agency Set Code=@Code, Airport=@Airport, [Address]=@Address, ZipCode=@ZipCode, " +
                "City=@City, Country=@Country, IsClosed=@IsClosed WHERE id=@id");
            command.AddParameter("Code", agency.Code);
            command.AddParameter("Airport", agency.Airport);
            command.AddParameter("Address", agency.Address);
            command.AddParameter("ZipCode", agency.ZipCode);
            command.AddParameter("City", agency.City);
            command.AddParameter("Country", agency.Country);
            command.AddParameter("IsClosed", agency.IsClosed);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
