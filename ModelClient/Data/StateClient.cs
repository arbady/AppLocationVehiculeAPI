using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class StateClient : StateGlobal
    {
        public StateClient(){}
        public StateClient(int id, StateType stateType, string description)
        {
            Id = id;
            StateType = stateType;
            Description = description;
        }
        public StateClient(StateType stateType, string description)
        {
            StateType = stateType;
            Description = description;
        }
    }
}
