namespace Projetos_Curso_CSharp.Myo.OO.Abstração {

    /*
        Usar abstract na classe permite que ela continue sendo uma superclasse
        assim impedindo que ela seja instanciada, porém podendo usar ela como
        uma superclasse normal e como tipo de variaveis.
    */

    abstract class Account {

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() {
        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }


    }
}
