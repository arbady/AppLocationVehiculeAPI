﻿using ModelGlobal.Data;
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
    public class VehicleGlobalService : BaseService, IRepoVehicle<VehicleGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Vehicle WHERE Id=@Id");
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<VehicleGlobal> Get()
        {
            Command command = new Command("Select * FROM Vehicle");
            //chaque ligne du reader est convertie au format vehicle
            return _connection.ExecuteReader(command, v => v.ToVehicle());
        }

        public VehicleGlobal Get(int id)
        {
            Command command = new Command("Select * FROM Vehicle WHERE id=@id");
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, v => v.ToVehicle()).SingleOrDefault();
        }

        public int Post(VehicleGlobal vehicule)
        {
            Command command = new Command
                ("INSERT INTO Vehicle (RegistrationNum, NbPlace, NbDoor, Fuel, AirCo, Gps, StateId, ModelId, " +
                "CategoryId) output inserted.id VALUES " +
                "(@RegistrationNum, @NbPlace, @NbDoor, @Fuel, @AirCo, @Gps, @StateId, @ModelId, @CategoryId);");
            
            command.AddParameter("RegistrationNum", vehicule.RegistrationNum);
            command.AddParameter("NbPlace", vehicule.NbPlace);
            command.AddParameter("NbDoor", vehicule.NbDoor);
            command.AddParameter("Fuel", vehicule.Fuel);
            command.AddParameter("AirCo", vehicule.AirCo);
            command.AddParameter("Gps", vehicule.Gps);
            command.AddParameter("StateId", vehicule.StateId);
            command.AddParameter("ModelId", vehicule.ModelId);
            command.AddParameter("CategoryId", vehicule.CategoryId);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, VehicleGlobal vehicule)
        {
            Command command = new Command
                ("UPDATE Vehicle Set RegistrationNum=@RegistrationNum, NbPlace=@NbPlace, NbDoor=@NbDoor, " +
                "Fuel=@Fuel, AirCo=@AirCo, Gps=@Gps, StateId=@StateId, ModelId=@ModelId, CategoryId=@CategoryId" +
                " WHERE id=@id");
            
            command.AddParameter("RegistrationNum", vehicule.RegistrationNum);
            command.AddParameter("NbPlace", vehicule.NbPlace);
            command.AddParameter("NbDoor", vehicule.NbDoor);
            command.AddParameter("Fuel", vehicule.Fuel);
            command.AddParameter("AirCo", vehicule.AirCo);
            command.AddParameter("Gps", vehicule.Gps);
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