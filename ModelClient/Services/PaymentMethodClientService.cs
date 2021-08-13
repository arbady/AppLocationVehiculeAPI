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
    public class PaymentMethodClientService : IRepoPaymentMethod<PaymentMethodClient>
    {
        private IRepoPaymentMethod<PaymentMethodGlobal> _paymentGlobalService;

        public PaymentMethodClientService()
        {
            _paymentGlobalService = new PaymentMethodGlobalService();
        }

        public bool Delete(int id)
        {
            return _paymentGlobalService.Delete(id);
        }

        public IEnumerable<PaymentMethodClient> Get()
        {
            return _paymentGlobalService.Get().Select(p => p.ToPaymentMethodClient());
        }

        public PaymentMethodClient Get(int id)
        {
            return _paymentGlobalService.Get(id)?.ToPaymentMethodClient();
        }

        public int Post(PaymentMethodClient paymentMethod)
        {
            return _paymentGlobalService.Post(paymentMethod.ToPaymentMethodGlobal());
        }

        public bool Put(int id, PaymentMethodClient paymentMethod)
        {
            return _paymentGlobalService.Put(id, paymentMethod.ToPaymentMethodGlobal());
        }
    }
}
