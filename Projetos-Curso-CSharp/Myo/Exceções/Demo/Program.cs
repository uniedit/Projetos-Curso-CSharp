using Projetos_Curso_CSharp.Myo.Exceções.Demo.Entities;
using Projetos_Curso_CSharp.Myo.Exceções.Demo.Entities.Exceptions;
using System;

namespace Projetos_Curso_CSharp.Myo.Exceções.Demo {
    class Program {
        public void Main(string[] args) {

            // Outras versões -> https://github.com/acenelio/exceptions1-csharp
            try {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
                Console.WriteLine("");

                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine($"Reservation: {reservation}");
            } catch (DomainException err) {
                Console.WriteLine($"Error in reservation: {err.Message}");
            } catch (FormatException err) {
                Console.WriteLine($"Error in format: {err.Message}");
            } catch (Exception err) {
                Console.WriteLine($"Unexpected Error: {err.Message}");
            }

        }
    }
}
