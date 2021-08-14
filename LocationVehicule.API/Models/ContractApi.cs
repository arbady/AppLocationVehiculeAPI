using ModelClient.Data;
using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class ContractApi : ContractClient
    {
        public ContractApi(int id, int contractNum, DateTime realReturnDate, string departKm, string backKm, DateTime contractDate, float amountTotHTVA, float amountTotTVA, bool signed, int reservationId, int vehicleId, int penalizationId)
        {
            Id = id;
            ContractNum = contractNum;
            RealReturnDate = realReturnDate;
            DepartKm = departKm;
            BackKm = backKm;
            ContractDate = contractDate;
            AmountTotHTVA = amountTotHTVA;
            AmountTotTVA = amountTotTVA;
            Signed = signed;
            ReservationId = reservationId;
            VehicleId = vehicleId;
            PenalizationId = penalizationId;
        }       
    }
}
