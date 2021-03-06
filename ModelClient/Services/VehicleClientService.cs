using ModelClient.Data;
using ModelClient.Mapper;
using ModelGlobal.Data;
using ModelGlobal.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Services
{
    public class VehicleClientService : IRepoVehicle<VehicleClient>
    {
        private IRepoVehicle<VehicleGlobal> _vehicleGlobalService;

        public VehicleClientService()
        {
            _vehicleGlobalService = new VehicleGlobalService();
        }

        public bool Delete(int id)
        {
            return _vehicleGlobalService.Delete(id);
        }

        public IEnumerable<VehicleClient> Get()
        {
            return _vehicleGlobalService.Get().Select(v => v.ToVehicleClient());
        }

        public VehicleClient Get(int id)
        {
            return _vehicleGlobalService.Get(id)?.ToVehicleClient();
        }

        public IEnumerable<VehicleClient> GetCatForVehicle(int id)
        {
            return _vehicleGlobalService.GetCatForVehicle(id).Select(v => v.ToVehicleClient());
        }
        public IEnumerable<VehicleClient> GetVehiclesByAgency(int id)
        {
            return _vehicleGlobalService.GetVehiclesByAgency(id).Select(v => v.ToVehicleClient());
        }

        public IEnumerable<VehicleClient> GetDispoForVehicle(DateTime tdate, int idAgency, int idCategory)
        {
            return _vehicleGlobalService.GetDispoForVehicle(tdate, idAgency, idCategory).Select(d => d.ToVehicleClient());
        }
        public int Post(VehicleClient vehicule)
        {
            return _vehicleGlobalService.Post(vehicule.ToVehicleGlobal());
        }

        public bool Put(int id, VehicleClient vehicule)
        {
            return _vehicleGlobalService.Put(id, vehicule.ToVehicleGlobal());
        }
    }
}
