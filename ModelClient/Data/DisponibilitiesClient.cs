using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class DisponibilitiesClient
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public bool IsInput { get; set; }
        public int AgencyId { get; set; }
        public int VehicleId { get; set; }
        public AgencyGlobal Agency { get; set; }
        public VehicleGlobal Vehicle { get; set; }
        public DisponibilitiesClient(){
            //this.Agency = new AgencyClient();
        }
        public DisponibilitiesClient(int id, DateTime entryDate, bool isInput, int agencyId, int vehicleId 
            /*AgencyGlobal agency, VehicleGlobal vehicle*/) : this()
        {
            Id = id;
            EntryDate = entryDate;
            IsInput = isInput;
            AgencyId = agencyId;
            VehicleId = vehicleId;
            //Agency = agency;
            //Vehicle = vehicle;
        }
        public DisponibilitiesClient(DateTime entryDate, bool isInput, int agencyId, 
            int vehicleId/*, AgencyGlobal agency, VehicleGlobal vehicle*/) : this()
        {
            EntryDate = entryDate;
            IsInput = isInput;
            AgencyId = agencyId;
            VehicleId = vehicleId;
            //Agency = agency;
            //Vehicle = vehicle;
        }
    }
}
