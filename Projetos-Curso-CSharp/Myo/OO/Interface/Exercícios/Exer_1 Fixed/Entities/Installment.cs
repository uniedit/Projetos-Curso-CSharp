using System;
using System.Globalization;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed.Entities {
    class Installment {

        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString() {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
