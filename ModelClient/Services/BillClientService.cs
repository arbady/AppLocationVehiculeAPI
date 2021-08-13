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
    public class BillClientService : IRepoBill<BillClient>
    {
        private IRepoBill<BillGlobal> _billGlobalService;

        public BillClientService()
        {
            _billGlobalService = new BillGlobalService();
        }

        public bool Delete(int id)
        {
            return _billGlobalService.Delete(id);
        }

        public IEnumerable<BillClient> Get()
        {
            return _billGlobalService.Get().Select(b => b.ToBillClient());
        }

        public BillClient Get(int id)
        {
            return _billGlobalService.Get(id)?.ToBillClient();
        }

        public int Post(BillClient bill)
        {
            return _billGlobalService.Post(bill.ToBillGlobal());
        }

        public bool Put(int id, BillClient bill)
        {
            return _billGlobalService.Put(id, bill.ToBillGlobal());
        }
    }
}
