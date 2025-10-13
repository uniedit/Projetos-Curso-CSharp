using System;
using System.Globalization;
using Projetos_Curso_CSharp.Myo.OO.Interface.Entities;
using Projetos_Curso_CSharp.Myo.OO.Interface.Services;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Com_Interface {
     class Program {
        public void Main(string[] args) {

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Vehicle vehicle = new Vehicle(carModel);

            //CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));
            CarRental carRental = new CarRental(start, finish, vehicle);

            BrazilTaxService brazilTaxService = new BrazilTaxService();

            //RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            RentalService rentalService = new RentalService(hour, day, brazilTaxService);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
