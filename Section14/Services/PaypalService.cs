using Section14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            var percentage = (2 * amount) / 100;
            var result = amount + percentage;
            return result;
        }

        public double Interest(double amount, int months)
        {
            var percentage = (1 * amount) / 100;
            var result = amount + percentage * months ;
            return result;
        }
    }
}
