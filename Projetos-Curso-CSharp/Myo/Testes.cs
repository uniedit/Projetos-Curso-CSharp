using Projetos_Curso_CSharp.Myo.Enumeração.Entities.Enums;
using Projetos_Curso_CSharp.Myo.Enumeração.Exercícios.Exer_3.Entities;
using System;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp {
    class Testes {
        static void Main(string[] args) {

            //double insano = 1.69;
            //Console.WriteLine($"Hi\nTyler!! {insano.ToString("F", C.I)}");

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

            //Console.WriteLine("ORDER SUMMARY:");
            //Console.WriteLine($"Order moment: {order.Moment}");
            //Console.WriteLine($"Order status: {order.Status}");
            //Console.WriteLine($"Client: {order.client} {birthDate} - {email}");
            //Console.WriteLine("Order items:");

            Console.WriteLine(order);

            }
        }
    }