namespace Projetos_Curso_CSharp.Myo.OO.Herança {
    class SavingsAccount : Account {
        
        public double interestRate { get; set; }

        public SavingsAccount() {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base (number, holder, balance) {
            this.interestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * interestRate;
        }

        // override Withdraw -> devido ao uso da palavra "virtual" na função antes
        public override void Withdraw(double amount) {
            //Balance -= amount;

            // Ao usar o "base", o programa vai se utilizar da função já criada na SuperClasse.
            base.Withdraw(amount); // Reaproveitamento da SuperClasse, metodo comum da mesma
            Balance -= 2.0; // Descontando do "Balance"
        }

    }
}
