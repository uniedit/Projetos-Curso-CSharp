using Projetos_Curso_CSharp.Myo.Enumeração.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.Enumeração.Exercícios.Exer_3.Entities {
    class Order {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> orderItem { get; set; } = new List<OrderItem>();
        public Client client { get; set; } = new Client();
        public Product product { get; set; } = new Product();

        public Order() {
        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            this.client = client;
        }

        public Order(DateTime moment, OrderStatus status, Client client, Product product) {
            Moment = moment;
            Status = status;
            this.client = client;
            this.product = product;
        }

        public void AddItem(OrderItem item) { 
            orderItem.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            orderItem.Remove(item);
        }

        double sum;
        public double Total(double sum) {
            return this.sum = this.sum + sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {client.Name} ({client.BirthDate.ToString("dd/MM/yyyy")}) - {client.Email}");
            sb.AppendLine("Order items:");

            foreach (OrderItem item in orderItem) {
                sb.Append(item.product.Name);
                sb.Append(", $");
                sb.Append(item.product.Price.ToString("F2", C.I));
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: $");
                sb.Append(item.SubTotal().ToString("F2", C.I));
                sb.AppendLine();
            }
            sb.Append("Total price: $");
            sb.AppendLine(sum.ToString("F2", C.I));
            return sb.ToString();
        }

    }
}
