using Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed.Entities;
using System;
using System.Globalization;
using System.Text;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed.Services {
    class ContractService {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interests(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }

    }
}
