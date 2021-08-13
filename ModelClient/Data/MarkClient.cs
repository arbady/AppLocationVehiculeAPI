using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class MarkClient : MarkGlobal
    {
        public MarkClient(){}
        public MarkClient(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public MarkClient(string name)
        {
            Name = name;
        }
    }
}
