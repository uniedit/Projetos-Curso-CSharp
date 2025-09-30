namespace Projetos_Curso_CSharp.Myo.OO.Herança {
    class Account {

        public int Number { get; private set; }
        public string Holder { get; private set; }
        // Caso do modificador de acesso "protected" faz com que as subclasses possam
        // acessar-la, porém apenas em subclasses, não em classes fora desse escopo.
        public double Balance { get; protected set; }

        public Account() {
        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount) {
            Balance -= amount;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }


    }
}
