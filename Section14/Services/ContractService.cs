using Section14.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            var valueInstallment = contract.TotalValue / months;
            var sum = 0.0;
            DateTime dateInstallment;

            for (int i = 1; i <= months; i++) 
            {
                sum = _onlinePaymentService.Interest(valueInstallment, months);
                sum += _onlinePaymentService.PaymentFee(sum);

                dateInstallment = contract.Date.AddMonths(i);

                contract.Installments.Add(new Installment(dateInstallment, sum));

                foreach(Installment obj in contract.Installments)
                {
                    Console.WriteLine(obj.DueDate + " - " + obj.Amount.ToString("C"), CultureInfo.InvariantCulture );
                }
            }
        }
    }
}
