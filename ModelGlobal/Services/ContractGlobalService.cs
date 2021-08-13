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
    public class ContractGlobalService : BaseService, IRepoContract<ContractGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Contract WHERE Id=@Id");
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<ContractGlobal> Get()
        {
            Command command = new Command("Select * FROM Contract");
            //chaque ligne du reader est convertie au format contract
            return _connection.ExecuteReader(command, c => c.ToContract());
        }

        public ContractGlobal Get(int id)
        {
            Command command = new Command("Select * FROM Contract WHERE id=@id");
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, c => c.ToContract()).SingleOrDefault();
        }

        public int Post(ContractGlobal contract)
        {
            Command command = new Command
                ("INSERT INTO Contract (ContractNum, RealReturnDate, ContractDate, AmountTotHTVA, " +
                "AmountTotTVA, Signed, ReservationId, VehicleId, PenalizationId) " +
                "output inserted.id VALUES (@ContractNum, @RealReturnDate, @ContractDate, @AmountTotHTVA, " +
                "@AmountTotTVA, @Signed, @ReservationId, @VehicleId, @PenalizationId);");

            command.AddParameter("ContractNum", contract.ContractNum);
            command.AddParameter("RealReturnDate", contract.RealReturnDate);
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
            Command command = new Command
                ("UPDATE Contract Set ContractNum=@ContractNum, RealReturnDate=@RealReturnDate, " +
                "ContractDate=@ContractDate, AmountTotHTVA=@AmountTotHTVA, AmountTotTVA=@AmountTotTVA, " +
                "Signed=@Signed, ReservationId=@ReservationId, VehicleId=@VehicleId, PenalizationId=@PenalizationId " +
                "WHERE id=@id");

            command.AddParameter("ContractNum", contract.ContractNum);
            command.AddParameter("RealReturnDate", contract.RealReturnDate);
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
