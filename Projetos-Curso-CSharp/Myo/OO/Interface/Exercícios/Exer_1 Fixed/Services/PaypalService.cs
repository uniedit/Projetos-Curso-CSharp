namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed.Services {
    class PaypalService : IOnlinePaymentService {

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        // Modo de "herdar" os metodos da interface IOnlinePaymentService
        public double Interests(double amount, int months) {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount) {
            return amount * FeePercentage;
        }

    }
}
