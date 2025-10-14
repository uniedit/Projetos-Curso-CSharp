using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1.Entities {
    class Installment {

        public Installment() {
        }

        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }
        
    }
}
