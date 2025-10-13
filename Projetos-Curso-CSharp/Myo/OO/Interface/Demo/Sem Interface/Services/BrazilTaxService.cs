namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Sem_Interface.Services {
    class BrazilTaxService {

        public double Tax(double amount) {
            if (amount <= 100) {
                return amount * 0.2;
            } else {
                return amount * 0.15;
            }
        }

    }
}
