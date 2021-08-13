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
    public class DisponobilitiesGlobalService : BaseService, IRepoDisponibilities<DisponibilitiesGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Disponibilities WHERE Id=@Id");
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<DisponibilitiesGlobal> Get()
        {
            Command command = new Command("Select * FROM Disponibilities");
            //chaque ligne du reader est convertie au format Disponibilities
            return _connection.ExecuteReader(command, d => d.ToDisponibilities());
        }

        public DisponibilitiesGlobal Get(int id)
        {
            Command command = new Command("Select * FROM Disponibilities WHERE id=@id");
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, d => d.ToDisponibilities()).SingleOrDefault();
        }

        public int Post(DisponibilitiesGlobal disponibilities)
        {
            Command command = new Command
                ("INSERT INTO Disponibilities (AvailDateDepart, AvailDateReturn, AgencyId, VehicleId) " +
                "output inserted.id VALUES (@AvailDateDepart, @AvailDateReturn, @AgencyId, @VehicleId);");

            command.AddParameter("AvailDateDepart", disponibilities.AvailDateDepart);
            command.AddParameter("AvailDateReturn", disponibilities.AvailDateReturn);
            command.AddParameter("AgencyId", disponibilities.AgencyId);
            command.AddParameter("VehicleId", disponibilities.VehicleId);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, DisponibilitiesGlobal disponibilities)
        {
            Command command = new Command
                ("UPDATE Disponibilities Set AvailDateDepart=@AvailDateDepart, AvailDateReturn=@AvailDateReturn, " +
                "AgencyId=@AgencyId, VehicleId=@VehicleId WHERE id=@id");

            command.AddParameter("AvailDateDepart", disponibilities.AvailDateDepart);
            command.AddParameter("AvailDateReturn", disponibilities.AvailDateReturn);
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
