namespace Projetos_Curso_CSharp.Myo.OO.Hash.Igualdade.Entities {
    struct Point {

        public int X { get; set; }
        public int Y { get; set; }

        // Faz um construtor que aceita tanto X como Y 
        // Também aceitando vazio como argumento
        // Além disso, por causa do seu tipo "stuct", ela sempre é inicializada, com 0 ou null
        // Por isso é possivel usar o this() para gerar um construtor vazio
        public Point(int x, int y) : this() {
            X = x;
            Y = y;
        }

    }
}
