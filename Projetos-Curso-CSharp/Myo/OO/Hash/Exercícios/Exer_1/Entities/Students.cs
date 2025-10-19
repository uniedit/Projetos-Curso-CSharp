namespace Projetos_Curso_CSharp.Myo.OO.Hash.Exercícios.Exer_1.Entities {
    class Students {

        public int UniqueCode { get; set; }

        public override int GetHashCode() {
            return UniqueCode.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (!(obj is Students)) {
                return false;
            }

            Students other = obj as Students;
            return UniqueCode.Equals(other.UniqueCode);
        }

    }
}
