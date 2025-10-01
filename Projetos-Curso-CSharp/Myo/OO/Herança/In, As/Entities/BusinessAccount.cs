namespace Projetos_Curso_CSharp.Myo.OO.Herança {
    // Usando " : " para referenciar a superclasse
    class BusinessAccount : Account {

        public double LoanLimit { get; set; }

        public BusinessAccount() {
        }

        /* 
            * Usa-se " : base " para se referenciar um construtor de outra classe os metodos que 
            * devem ser herdados da superclasse para essa subclasse.
            * Mesma coisa que reaproveitar os argumentos do construtor da superclasse usando a palavra "base"
        */

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
        }

    }
}
