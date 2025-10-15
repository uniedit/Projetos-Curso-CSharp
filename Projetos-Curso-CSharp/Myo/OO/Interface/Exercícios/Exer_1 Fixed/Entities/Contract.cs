using System;
using System.Collections.Generic;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1_Fixed.Entities {
    class Contract {
        public Contract() {
        }

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        
        // Instanciação de varias classes Installments, dado que é uma relação 1 para muitos
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;

            // Motivo de estar no construtor : ?????, mas está
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment) {
            Installments.Add(installment);
        }

    }
}
