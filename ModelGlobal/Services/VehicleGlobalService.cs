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
    public class VehicleGlobalService : BaseService, IRepoVehicle<VehicleGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("SP_DeleteVehicle", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<VehicleGlobal> Get()
        {
            Command command = new Command("SP_GetAllVehicle", true);
            //chaque ligne du reader est convertie au format vehicle
            return _connection.ExecuteReader(command, v => v.ToVehicle());
        }

        public VehicleGlobal Get(int id)
        {
            Command command = new Command("SP_GetByIdVehicle", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, v => v.ToVehicle()).SingleOrDefault();
        }

        public IEnumerable<VehicleGlobal> GetCatForVehicle(int id)
        {
            Command command = new Command("SP_VehicleCat", true);

            command.AddParameter("catid", id);
            return _connection.ExecuteReader(command, c => c.ToVehicle());
        }
        public IEnumerable<VehicleGlobal> GetVehiclesByAgency(int id)
        {
            Command command = new Command("SP_AllVehicleByAgency", true);

            command.AddParameter("agencyid", id);
            return _connection.ExecuteReader(command, c => c.ToVehicle());
        }

        public IEnumerable<VehicleGlobal> GetDispoForVehicle(DateTime tdate, int idAgency, int idCategory)
        {
            Command command = new Command("SP_VehicleIsDispo", true);
            //command.AddParameter("vehicleId", idVehicle);
            command.AddParameter("date", tdate);
            command.AddParameter("agencyId", idAgency);
            command.AddParameter("categoryId", idCategory);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, d => d.ToVehicle());
        }
        public int Post(VehicleGlobal vehicule)
        {
            Command command = new Command("SP_InsertVehicle", true);
            
            command.AddParameter("RegistrationNum", vehicule.RegistrationNum);
            command.AddParameter("Characteristic", vehicule.Characteristic);
            command.AddParameter("NbPlace", vehicule.NbPlace);
            command.AddParameter("NbDoor", vehicule.NbDoor);
            command.AddParameter("Fuel", vehicule.Fuel);
            command.AddParameter("AirCo", vehicule.AirCo);
            command.AddParameter("Gps", vehicule.Gps);
            command.AddParameter("Transmission", vehicule.Transmission);
            command.AddParameter("StateId", vehicule.StateId);
            command.AddParameter("ModelId", vehicule.ModelId);
            command.AddParameter("CategoryId", vehicule.CategoryId);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, VehicleGlobal vehicule)
        {
            Command command = new Command("SP_UpdateVehicle", true);
            
            command.AddParameter("RegistrationNum", vehicule.RegistrationNum);
            command.AddParameter("Characteristic", vehicule.Characteristic);
            command.AddParameter("NbPlace", vehicule.NbPlace);
            command.AddParameter("NbDoor", vehicule.NbDoor);
            command.AddParameter("Fuel", vehicule.Fuel);
            command.AddParameter("AirCo", vehicule.AirCo);
            command.AddParameter("Gps", vehicule.Gps);
            command.AddParameter("Transmission", vehicule.Transmission);
            command.AddParameter("StateId", vehicule.StateId);
            command.AddParameter("ModelId", vehicule.ModelId);
            command.AddParameter("CategoryId", vehicule.CategoryId);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
