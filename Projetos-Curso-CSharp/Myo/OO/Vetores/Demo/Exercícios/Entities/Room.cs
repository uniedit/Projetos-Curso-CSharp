using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo.Entities {
    internal class Room {

        public string nome { get; set; }
        public string email { get; set; }
        public int quarto { get; set; }

        public Room(string nome, string email) {
            this.nome = nome;
            this.email = email;
        }
    }
}
