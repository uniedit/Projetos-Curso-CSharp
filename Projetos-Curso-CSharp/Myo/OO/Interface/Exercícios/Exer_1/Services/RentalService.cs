using System;
using System.Globalization;
using System.Text;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1.Services {
    class RentalService {

        private IPaymentService _paymentService;

        public RentalService(IPaymentService paymentService) {
            _paymentService = paymentService;
        }

        public string NewInstallment(double value, int quota, DateTime date) {

            StringBuilder sb = new StringBuilder();

            DateTime date1 = date.AddMonths(1);

            value = value / quota;

            for (int i = 1; i <= quota; i++) {
                sb.AppendLine($"{date1.ToString("dd/MM/yyyy")} - " +
                    $"{_paymentService.Tax(value, i).ToString("F2", CultureInfo.InvariantCulture)}");
                date1 = date1.AddMonths(1);
            }

            return sb.ToString();

        }

    }
}
