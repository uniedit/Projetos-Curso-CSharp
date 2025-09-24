using Projetos_Curso_CSharp.Myo.Enumeração.Entities;
using Projetos_Curso_CSharp.Myo.Enumeração.Entities.Enums;
using System;
using C = Projetos_Curso_CSharp.Global.Global;

internal class Program {
    public void Method() {

        Console.Write("Enter department's name: ");
        string deptName = Console.ReadLine();

        Console.WriteLine("Enter worker data:");
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Level (Junior/MidLevel/Senior): ");
        WorkerLevel workerLevel = (WorkerLevel) Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

        Console.Write("Base salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), C.I);

        Department dept = new Department(deptName);
        // Para fazer a Associação entre departamento e a class worker, tem que usar o construtor
        // recebendo como parametro a classe Department.
        Worker worker = new Worker(name, workerLevel, baseSalary, dept);


        Console.Write("How many contracts to this worker? ");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //for (int i = 0; i < count; i++) {
        for (int i = 1; i <= count; i++) {
            Console.WriteLine($"Enter #{i} contract data:");
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), C.I);

            Console.Write("Duration (hours): ");
            int hours = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(date, valuePerHour, hours);
            worker.AddContract(contract);
        }

        Console.WriteLine();

        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string monthAndYear = Console.ReadLine();
        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));

        double income = worker.Income(year, month);

        // Console.WriteLine($"Name: {worker.Name}");
        // Console.WriteLine($"Department: {worker.Department.Name}");
        Console.Write(worker);
        // Console.WriteLine($"Income for {month}/{year}: {income}");
        Console.WriteLine($"Income for {monthAndYear}: {income.ToString("F2", C.I)}");

    }
}
