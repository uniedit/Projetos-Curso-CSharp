using Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1.Services;
using System;
using System.Collections.Generic;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Exercícios.Exer_1.Entities {
    class Contract {

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

    }
}
