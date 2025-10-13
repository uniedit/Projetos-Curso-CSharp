using Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Com_Interface.Services;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Services {
    class BrazilTaxService : ITaxService {

        public double Tax(double amount) {
            if (amount <= 100) {
                return amount * 0.2;
            } else {
                return amount * 0.15;
            }
        }

    }
}
