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
    public class DisponibilitiesGlobalService : BaseService, IRepoDisponibilities<DisponibilitiesGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("SP_DeleteDispo", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<DisponibilitiesGlobal> Get()
        {
            Command command = new Command("SELECT * FROM V_Dispo");
            //Command command = new Command("SP_GetAllDispo", true);
            //chaque ligne du reader est convertie au format Disponibilities
            return _connection.ExecuteReader(command, d => d.ToDisponibilities());
        }

        public DisponibilitiesGlobal Get(int id)
        {
            Command command = new Command("SP_GetByIdDispo", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, d => d.ToDisponibilities()).SingleOrDefault();
        }

        public int Post(DisponibilitiesGlobal disponibilities)
        {
            Command command = new Command("SP_InsertDispo", true);

            command.AddParameter("entryDate", disponibilities.EntryDate);
            command.AddParameter("isinput", disponibilities.IsInput);
            command.AddParameter("AgencyId", disponibilities.AgencyId);
            command.AddParameter("VehicleId", disponibilities.VehicleId);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, DisponibilitiesGlobal disponibilities)
        {
            Command command = new Command("SP_UpdateDispo", true);

            command.AddParameter("entryDate", disponibilities.EntryDate);
            command.AddParameter("isinput", disponibilities.IsInput);
            command.AddParameter("AgencyId", disponibilities.AgencyId);
            command.AddParameter("VehicleId", disponibilities.VehicleId);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
