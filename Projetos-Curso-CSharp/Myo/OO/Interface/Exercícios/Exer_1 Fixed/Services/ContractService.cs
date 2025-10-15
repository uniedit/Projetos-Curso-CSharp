using Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed.Entities;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed.Services {
    class ContractService {

        // Modo de declarar uma interface em uma classe
        private IOnlinePaymentService _onlinePaymentService;

        // Construtor com a interface
        public ContractService(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        /*
            Modo de fazer com que a classe contrato tenha varios "Installments" por meio do
            "contract.AddInstallment" previamente adicionado na classe contract, fazendo com
            que adicione na lista "Installment" a propria classe.

            Também o meio de fazer a ligação entre varias e varias classe de modo que:
                ------------------------------------------
                Classe ContractService -> IOnlinePayment
                Interface IOnlinePayment ->* PaypalService
                ------------------------------------------
                Classe ContractService -> Contract
                Classe Contract ->* Installment
                ------------------------------------------
        */

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
