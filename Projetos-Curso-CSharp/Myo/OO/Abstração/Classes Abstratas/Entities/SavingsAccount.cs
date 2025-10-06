namespace Projetos_Curso_CSharp.Myo.OO.Abstração {
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

        public override void Withdraw(double amount) {

            base.Withdraw(amount); 
            Balance -= 2.0; 
        }

    }
}
