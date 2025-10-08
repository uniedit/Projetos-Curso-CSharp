using System;

namespace Projetos_Curso_CSharp.Myo.Exceções.Demo.Entities.Exceptions {
    class DomainException : ApplicationException {

        public DomainException(string message) : base(message) {
        }

    }
}
