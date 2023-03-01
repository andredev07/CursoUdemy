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
            var result = amount * 0.2;
            return result;
        }

        public double Interest(double amount, int months)
        {
            var result = amount + 0.1 * months;
            return result;
        }
    }
}
