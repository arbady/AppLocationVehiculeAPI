using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class ModeleClient : ModelGlobale
    {
        public ModeleClient(){}
        public ModeleClient(int id, string name, int markId)
        {
            Id = id;
            Name = name;
            MarkId = markId;
        }
        public ModeleClient(string name, int markId)
        {
            Name = name;
            MarkId = markId;
        }
    }
}
