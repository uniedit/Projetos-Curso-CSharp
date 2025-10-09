using System;

namespace Projetos_Curso_CSharp.Myo.Exceções.Exercícios.Exer_1.Entities.Exceptions {
    class DomainException : ApplicationException {

        public DomainException(string message) : base(message) {
        }
    
    }
}
