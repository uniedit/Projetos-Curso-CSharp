using Projetos_Curso_CSharp.Myo.Enumeração.Entities.Enums;
using Projetos_Curso_CSharp.Myo.Enumeração.Exercícios.Exer_3.Entities;
using C = Projetos_Curso_CSharp.Global.Global;
using System;

internal class Program {
    public void Method() {

        // print - https://nyan.bbaka.moe/pPmqv_RfHtym.png

        DateTime moment = DateTime.Now;

        Console.WriteLine("Enter cliente data:");
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter order data:");
        Console.Write("Status: ");
        OrderStatus orderStatus = (OrderStatus) Enum.Parse(typeof(OrderStatus), Console.ReadLine());

        Client client = new Client(name, email, birthDate);

        Order order = new Order(moment, orderStatus, client);

        Console.Write("How many items to this order? ");
        int count = int.Parse(Console.ReadLine());

        double sum;

        for (int i = 1; i <= count; i++) {
            Console.WriteLine($"Enter #{i} item data:");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();

            Console.Write("Product price: ");
            double productPrice = double.Parse(Console.ReadLine(), C.I);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(productName, productPrice);

            OrderItem orderItem = new OrderItem(quantity, productPrice, product);

            order.AddItem(orderItem);

            sum = quantity * productPrice;
            order.Total(sum);
        }

        Console.WriteLine();
        Console.WriteLine(order);

    }
}
