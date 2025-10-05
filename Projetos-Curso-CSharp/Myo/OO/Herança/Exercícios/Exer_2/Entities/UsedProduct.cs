using System;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Herança.Exercícios.Exer_2.Entities {
    class UsedProduct : Product {

        public UsedProduct() {
        }

        public DateTime ManufectureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufectureDate)
            : base (name, price) {
            ManufectureDate = manufectureDate;
        }
        
        public override string PriceTag() {
            return $"{Name} (used) $ {Price.ToString("F2", C.I)} " +
                $"(Manufacture date: {ManufectureDate.ToString("dd/MM/yyyy")})";
        }

    }
}
