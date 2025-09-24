using System;

namespace Projetos_Curso_CSharp.Myo.Enumeração.Entities {
    class HourContract {

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours) {
            this.Date = date;
            this.ValuePerHour = valuePerHour;
            this.Hours = hours;
        }

        public double TotalValue() {
            return Hours * ValuePerHour;
        }

    }
}
