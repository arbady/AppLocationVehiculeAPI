using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class VehicleClient
    {
        public int Id { get; set; }
        public string RegistrationNum { get; set; }
        public string Characteristic { get; set; }
        public NbPlace NbPlace { get; set; }
        public NbDoor NbDoor { get; set; }
        public Fuel Fuel { get; set; }
        public bool AirCo { get; set; }
        public bool Gps { get; set; }
        public Transmission? Transmission { get; set; }
        public int StateId { get; set; }
        public int ModelId { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<DisponibilitiesClient> Disponibilities { get; set; }
        public VehicleClient()
        {
            this.Disponibilities = new List<DisponibilitiesClient>();
        }
        public VehicleClient(int id, string registrationNum, string characteristic, NbPlace nbPlace, 
            NbDoor nbDoor, Fuel fuel, bool airCo, bool gps, Transmission? transmission, int stateId, 
            int modelId, int categoryId) : this()
        {
            Id = id;
            RegistrationNum = registrationNum;
            Characteristic = characteristic;
            NbPlace = nbPlace;
            NbDoor = nbDoor;
            Fuel = fuel;
            AirCo = airCo;
            Gps = gps;
            Transmission = transmission;
            StateId = stateId;
            ModelId = modelId;
            CategoryId = categoryId;
        }
        public VehicleClient(string registrationNum, string characteristic, NbPlace nbPlace, NbDoor nbDoor, 
            Fuel fuel, bool airCo, bool gps, Transmission? transmission, int stateId, int modelId, 
            int categoryId) : this()
        {
            RegistrationNum = registrationNum;
            Characteristic = characteristic;
            NbPlace = nbPlace;
            NbDoor = nbDoor;
            Fuel = fuel;
            AirCo = airCo;
            Gps = gps;
            Transmission = transmission;
            StateId = stateId;
            ModelId = modelId;
            CategoryId = categoryId;
        }
    }
}
