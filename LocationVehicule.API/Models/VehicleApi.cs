using ModelClient.Data;
using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class VehicleApi : VehicleClient
    {
        public VehicleApi(int id, string registrationNum, string characteristic, NbPlace nbPlace, NbDoor nbDoor, Fuel fuel, bool airCo, bool gps, Transmission transmission, int stateId, int modelId, int categoryId)
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
    }
}
