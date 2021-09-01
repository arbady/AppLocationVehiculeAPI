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
    public class AgencyGlobalService : BaseService, IRepoAgency<AgencyGlobal>
    {
        public bool Delete(int id)
        {
            //Command command = new Command("Delete FROM Agency WHERE Id=@Id");
            Command command = new Command("SP_DeleteAgency", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<AgencyGlobal> Get()
        {
            //Command command = new Command("SELECT * FROM Agency");
            Command command = new Command("SP_GetAllAgency", true);
            //chaque ligne du reader est convertie au format agencyGlobal
            return _connection.ExecuteReader(command, a => a.ToAgency());
        }

        public AgencyGlobal Get(int id)
        {
            Command command = new Command("SP_GetByIdAgency", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, a => a.ToAgency()).SingleOrDefault();
        }
        public AgencyGlobal GetForVehicle(int vehicleid)
        {
            Command command = new Command("SP_GetAgencyByIdVehicle", true);
            command.AddParameter("idvehicle", vehicleid);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, a => a.ToAgency()).SingleOrDefault();
        }

        public int Post(AgencyGlobal agency)
        {
            Command command = new Command("SP_InsertAgency", true);
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
            Command command = new Command("SP_UpdateAgency", true);
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
