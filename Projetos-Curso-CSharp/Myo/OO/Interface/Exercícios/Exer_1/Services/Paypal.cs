namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1.Services {
    class Paypal : IPaymentService {

        public double Tax(double amount, int quota) {
            amount += ((amount * 0.01) * quota);
            return amount += ((amount * 0.02));
        }

    }
}
