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
    public class ContractGlobalService : BaseService, IRepoContract<ContractGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("SP_DeleteContract", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<ContractGlobal> Get()
        {
            Command command = new Command("SP_GetAllContract", true);
            //chaque ligne du reader est convertie au format contract
            return _connection.ExecuteReader(command, c => c.ToContract());
        }

        public ContractGlobal Get(int id)
        {
            Command command = new Command("SP_GetByIdContract", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, c => c.ToContract()).SingleOrDefault();
        }

        public int Post(ContractGlobal contract)
        {
            Command command = new Command("SP_InsertContract", true);

            command.AddParameter("ContractNum", contract.ContractNum);
            command.AddParameter("RealReturnDate", contract.RealReturnDate);
            command.AddParameter("DepartKm", contract.DepartKm);
            command.AddParameter("BackKm", contract.BackKm);
            command.AddParameter("ContractDate", contract.ContractDate);
            command.AddParameter("AmountTotHTVA", contract.AmountTotHTVA);
            command.AddParameter("AmountTotTVA", contract.AmountTotTVA);
            command.AddParameter("Signed", contract.Signed);
            command.AddParameter("ReservationId", contract.ReservationId);
            command.AddParameter("VehicleId", contract.VehicleId);
            command.AddParameter("PenalizationId", contract.PenalizationId);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, ContractGlobal contract)
        {
            Command command = new Command("SP_UpdateContract", true);

            command.AddParameter("ContractNum", contract.ContractNum);
            command.AddParameter("RealReturnDate", contract.RealReturnDate);
            command.AddParameter("DepartKm", contract.DepartKm);
            command.AddParameter("BackKm", contract.BackKm);
            command.AddParameter("ContractDate", contract.ContractDate);
            command.AddParameter("AmountTotHTVA", contract.AmountTotHTVA);
            command.AddParameter("AmountTotTVA", contract.AmountTotTVA);
            command.AddParameter("Signed", contract.Signed);
            command.AddParameter("ReservationId", contract.ReservationId);
            command.AddParameter("VehicleId", contract.VehicleId);
            command.AddParameter("PenalizationId", contract.PenalizationId);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
