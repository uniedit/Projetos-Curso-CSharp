namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed.Services {
    interface IOnlinePaymentService {

        double PaymentFee(double amount);
        double Interests(double amount, int months);

    }
}
