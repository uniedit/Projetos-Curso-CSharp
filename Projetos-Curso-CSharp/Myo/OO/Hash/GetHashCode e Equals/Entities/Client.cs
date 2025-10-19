namespace Projetos_Curso_CSharp.Myo.OO.Hash.GetHashCode_e_Equals.Entities {
    class Client {
        
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj) {
            // Vendo se a entrada -> obj é igual ao tipo Client
            if (!(obj is Client)) {
                return false;
            }

            // Fazendo downcasting de obj para client já que não vai haver perca de informações
            Client other = obj as Client;

            // Retonando o que queremos, no caso foi ver o Equals do Email
            return Email.Equals(other.Email);
        }

        // Padrao do GetHashCode
        public override int GetHashCode() {
            return Email.GetHashCode();
        }

    }
}
