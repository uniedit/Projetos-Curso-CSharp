namespace Projetos_Curso_CSharp.Myo.OO.Herança {

    // Caso a classe seja selada, nenhuma outra classe pode derivar dela
    sealed class SavingsAccountSealed : Account {
        
        public double interestRate { get; set; }

        public SavingsAccountSealed() {
        }

        public SavingsAccountSealed(int number, string holder, double balance, double interestRate)
            : base (number, holder, balance) {
            this.interestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * interestRate;
        }

        // Fazendo agora o sealed no metodo, ele não pode ser sobrescrito
        // Ps: Não pode ter sealed na classe 
        public sealed override void Withdraw(double amount) {
            base.Withdraw(amount); 
            Balance -= 2.0; 
        }

    }
}
