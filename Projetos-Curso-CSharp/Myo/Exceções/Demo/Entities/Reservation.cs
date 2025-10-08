using Projetos_Curso_CSharp.Myo.Exceções.Demo.Entities.Exceptions;
using System;

namespace Projetos_Curso_CSharp.Myo.Exceções.Demo.Entities {
    class Reservation {

        public Reservation() {
        }

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {
            if (checkOut <= checkIn) {
                throw new DomainException(
                "Error in reservation: Check-out date must be after Check-in.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int) duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut) {

            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now) {
                // throw new DomainException == Lançar uma nova exceção "Domain Exception" 
                // Lembrando que o "throw" corta a execução do metodo, logo else não funciona, assim como return
                throw new DomainException(
                "Error in reservation: Reservation dates for update must be future dates.");
            }
            if (checkOut <= checkIn) {
                throw new DomainException(
                "Error in reservation: Check-out date must be after Check-in.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString() {
            return $"Room " +
                $"{RoomNumber}" +
                $", check-in: " +
                $"{CheckIn.ToString("dd/MM/yyyy")}" +
                $", check-out: " +
                $"{CheckOut.ToString("dd/MM/yyyy")}" +
                $", " +
                $"{Duration()}" +
                $" nights.";
        }

    }
}
