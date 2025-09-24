using Projetos_Curso_CSharp.Myo.Enumeração.Entities;
using Projetos_Curso_CSharp.Myo.Enumeração.Entities.Enums;
using System;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class Enums {
        public void Method() {

            //    OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            //    OrderStatus os;
            //    Enum.TryParse("Delivered", out os);

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Enum dentro de uma String
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            // Enum para String
            OrderStatus os = (OrderStatus) Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(os);
        
        }
    }
}



