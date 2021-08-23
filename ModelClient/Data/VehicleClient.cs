using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class VehicleClient : VehicleGlobal
    {
        public VehicleClient(){}
        public VehicleClient(int id, string registrationNum, string characteristic, NbPlace nbPlace, NbDoor nbDoor, Fuel fuel, bool airCo, bool gps, Transmission? transmission, int stateId, int modelId, int categoryId)
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
        public VehicleClient(string registrationNum, string characteristic, NbPlace nbPlace, NbDoor nbDoor, Fuel fuel, bool airCo, bool gps, Transmission? transmission, int stateId, int modelId, int categoryId)
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
