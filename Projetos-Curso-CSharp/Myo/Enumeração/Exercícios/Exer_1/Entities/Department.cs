namespace Projetos_Curso_CSharp.Myo.Enumeração.Entities {
    class Department {

        public string Name;

        public Department() {
        }

        public Department(string name) {
            this.Name = name;
        }

        public override string ToString() {
            return Name;
        }

    }
}
