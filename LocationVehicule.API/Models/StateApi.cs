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
    public class StateApi : StateClient
    {
        public StateApi(int id, StateType stateType, string description)
        {
            Id = id;
            StateType = stateType;
            Description = description;
        }
    }
}
